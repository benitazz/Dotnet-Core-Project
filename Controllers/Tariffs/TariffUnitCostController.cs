using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MedicalBilingBackEnd.Common.Attributes;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using MedicalBilingBackEnd.Core.Repositories.Tariffs;
using MedicalBilingBackEnd.Resources.ApiToDomainResource.Tariffs;
using MedicalBilingMicroservice.Core;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalBilingBackEnd.Controllers.Tariffs
{
    [Route("api/tariffs/[controller]")]
    [SwaggerGroup("/api/tariffs/TariffUnitCosts")]
    public class TariffUnitCostController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ITariffUnitCostRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public TariffUnitCostController(IMapper mapper,
                                        ITariffUnitCostRepository repository,
                                        IUnitOfWork unitOfWork)
        {
            this._mapper = mapper;
            this._repository = repository;
            this._unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Get Tariff unit cost by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ///  <include file='../../wwwroot/comments.xml' path='XmlSummary/MyMembers[@name="getComment"]/*' />
        [HttpGet("{id}")]
        [EnableQuery]
        [ProducesResponseType(typeof(TariffUnitCostResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var tariffUnitCost = await this._repository.Get(id);

                if (tariffUnitCost == null)
                {
                    return NotFound();
                }

                var mappedResource = this._mapper.Map<TariffUnitCost, TariffUnitCostResource>(tariffUnitCost);
                return Ok(mappedResource);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        /// <summary>
        /// Get all tariff unit costs
        /// </summary>
        /// <returns></returns>
        ///  <include file='../../wwwroot/comments.xml' path='XmlSummary/MyMembers[@name="getAllComment"]/*' />
        [HttpGet]
        [EnableQuery]
        [ProducesResponseType(typeof(List<TariffUnitCostResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var tariffUnitCosts = await this._repository.GetAll();

                if (tariffUnitCosts == null)
                {
                    // return NotFound();
                    return Ok(new List<TariffUnitCostResource>());
                }

                var mappedResource = this._mapper.Map<List<TariffUnitCost>, List<TariffUnitCostResource>>(tariffUnitCosts);
                return Ok(mappedResource);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }

}