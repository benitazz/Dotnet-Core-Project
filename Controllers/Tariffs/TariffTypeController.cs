using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MedicalBilingBackEnd.Common.Attributes;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using MedicalBilingBackEnd.Core.Repositories.Tariffs;
using MedicalBilingBackEnd.Resources.ApiToDomainResource.Lookups;
using MedicalBilingBackEnd.Resources.DomainToApiResource.Lookups;
using MedicalBilingMicroservice.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalBilingBackEnd.Controllers.Lookups
{
    [Route("api/lookups/[controller]")]
    [SwaggerGroup("/api/lookups/TariffTypes")]
    // [SwaggerTag("Create, read, update and delete TariffType")]
    public class TariffTypeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ITariffTypeRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public TariffTypeController(
            IMapper mapper,
            ITariffTypeRepository repository,
            IUnitOfWork unitOfWork)
        {
            this._mapper = mapper;
            this._repository = repository;
            this._unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Get Tariff type by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ///  <include file='../../wwwroot/comments.xml' path='XmlSummary/MyMembers[@name="getComment"]/*' />
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(LookupResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var tariffType = await this._repository.Get(id);

                if (tariffType == null)
                {
                    return NotFound();
                }

                var mappedResource = this._mapper.Map<TariffType, LookupResource>(tariffType);
                return Ok(mappedResource);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        /// <summary>
        /// Get all tariff types
        /// </summary>
        /// <returns></returns>
        ///  <include file='../../wwwroot/comments.xml' path='XmlSummary/MyMembers[@name="getAllComment"]/*' />
        [HttpGet]
        [ProducesResponseType(typeof(List<LookupResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var tariffTypes = await this._repository.GetAll();

                if (tariffTypes == null)
                {
                    // return NotFound();
                    return Ok(new List<LookupResource>());
                }

                var mappedResource = this._mapper.Map<List<TariffType>, List<LookupResource>>(tariffTypes);
                return Ok(mappedResource);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Creates a new tariff type
        /// </summary>
        /// <param name="saveLookupResource"></param>
        /// <returns></returns>
        /// <include file='../../wwwroot/comments.xml' path='XmlSummary/MyMembers[@name="createComment"]/*' />
        [HttpPost]
        [ProducesResponseType(typeof(LookupResource), StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody]SaveLookupResource saveLookupResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var databaseKiosk = await this._repository.GetTariffTypeByName(saveLookupResource.Name);

                if (databaseKiosk != null)
                {
                    return StatusCode(StatusCodes.Status409Conflict,
                     $"The traffic type with the same already exists");
                }

                var tariffType = this._mapper.Map<SaveLookupResource, TariffType>(saveLookupResource);
                tariffType.CreatedDate = DateTime.Now;
                tariffType.UpdatedDate = DateTime.Now;
                tariffType.UpdatedBy = "Admin";
                tariffType.CreatedBy = "Admin";
                // tariffType.IsActive = true;
                this._repository.Add(tariffType);
                await this._unitOfWork.CompletedAsync();

                // tariffType = await _repository.Get(tariffType.Id);
                var results = this._mapper.Map<TariffType, LookupResource>(tariffType);

                return Ok(results);
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Update tariff type
        /// </summary>
        /// <param name="id"></param>
        /// <param name="saveLookupResource"></param>
        /// <returns></returns>
        /// <include file='../../wwwroot/comments.xml' path='XmlSummary/MyMembers[@name="updateComment"]/*' />
        [HttpPut("{id}")]
        [Produces(typeof(LookupResource))]
        public async Task<IActionResult> Put(int id, [FromBody]SaveLookupResource saveLookupResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var tariffType = await _repository.Get(id);

                if (tariffType == null)
                {
                    return NotFound();
                }

                tariffType = this._mapper.Map<SaveLookupResource, TariffType>(saveLookupResource, tariffType);
                // tariffType.UpdatedBy = "";
                //kioskType.IsActive = true;
                tariffType.UpdatedDate = DateTime.Now;
                await this._unitOfWork.CompletedAsync();

                var results = this._mapper.Map<TariffType, LookupResource>(tariffType);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}