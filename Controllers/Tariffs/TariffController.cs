using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CsvHelper;
using MedicalBilingBackEnd.Common.Attributes;
using MedicalBilingBackEnd.Common.Helpers.FileHelpers;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using MedicalBilingBackEnd.Core.Repositories.Tariffs;
using MedicalBilingBackEnd.Mapping.CsvMapping;
using MedicalBilingBackEnd.Resources.ApiToDomainResource.FileUploads;
using MedicalBilingBackEnd.Resources.ApiToDomainResource.Tariffs;
using MedicalBilingMicroservice.Core;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TinyCsvParser;
using TinyCsvParser.Tokenizer;

namespace MedicalBilingBackEnd.Controllers.Tariffs
{
    [Route("api/tariffs/[controller]")]
    [SwaggerGroup("/api/tariffs/Tariffs")]
    public class TariffController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ITariffRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileHelper _fileHelper;

        public TariffController(IMapper mapper,
                                ITariffRepository repository,
                                IUnitOfWork unitOfWork,
                                IFileHelper fileHelper)
        {
            this._mapper = mapper;
            this._repository = repository;
            this._unitOfWork = unitOfWork;
            this._fileHelper = fileHelper;
        }

        /// <summary>
        /// Get Tariff by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ///  <include file='../../wwwroot/comments.xml' path='XmlSummary/MyMembers[@name="getComment"]/*' />
        [HttpGet("{id}")]
        [EnableQuery]
        [ProducesResponseType(typeof(TariffResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var tariff = await this._repository.Get(id);

                if (tariff == null)
                {
                    return NotFound();
                }

                var mappedResource = this._mapper.Map<Tariff, TariffResource>(tariff);
                return Ok(mappedResource);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        /// <summary>
        /// Get all tariffs
        /// </summary>
        /// <returns></returns>
        ///  <include file='../../wwwroot/comments.xml' path='XmlSummary/MyMembers[@name="getAllComment"]/*' />
        [HttpGet]
        [EnableQuery]
        [ProducesResponseType(typeof(List<TariffResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var tariffs = await this._repository.GetAll();

                if (tariffs == null)
                {
                    // return NotFound();
                    return Ok(new List<TariffResource>());
                }

                var mappedResource = this._mapper.Map<List<Tariff>, List<TariffResource>>(tariffs);
                return Ok(mappedResource);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Upload tariff file
        /// </summary>
        /// <param name="tariffFileResource"></param>
        /// <returns></returns>
        /// <include file='../../wwwroot/comments.xml' path='XmlSummary/MyMembers[@name="createComment"]/*' />
        [HttpPost]
        [ProducesResponseType(typeof(TariffFileResource), StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody]TariffFileResource tariffFileResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var decodedFileData = this._fileHelper.DecodeBase64String(tariffFileResource.Base64EncodedData);
            var fileHash = this._fileHelper.CalculateCrypto(decodedFileData);

            try
            {
                using (TextReader textReader = new StringReader(decodedFileData))
                {
                    textReader.ReadLine();
                    using (var csv = new CsvReader(textReader))
                    {
                        csv.Configuration.HasHeaderRecord = false;
                        var map = new TariffMapping(tariffFileResource);
                        csv.Configuration.RegisterClassMap(map);
                        var tariffs = csv.GetRecords<Tariff>().ToList();
                        this._repository.AddRange(tariffs);
                        await this._unitOfWork.CompletedAsync();
                    }
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}