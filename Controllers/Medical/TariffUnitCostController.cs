using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MedicalEngineMicroService.Common.Attributes;
using MedicalEngineMicroService.Core.Models.Entities.Medical;
using MedicalEngineMicroService.Core.Repositories.Medical;
using MedicalEngineMicroService.Resources.ApiToDomainResource.Tariffs;
using MedicalEngineMicroService.Core;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalEngineMicroService.Controllers.Medical
{
    [Route("api/medical/[controller]")]
    [SwaggerGroup("/api/medical/TariffUnitCosts")]
    public class TariffUnitCostController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ITariffBaseUnitCostRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public TariffUnitCostController(IMapper mapper,
                                        ITariffBaseUnitCostRepository repository,
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

                var mappedResource = this._mapper.Map<TariffBaseUnitCost, TariffUnitCostResource>(tariffUnitCost);
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
                    return Ok(new List<TariffUnitCostResource>());
                }

                var mappedResource = this._mapper.Map<List<TariffBaseUnitCost>, List<TariffUnitCostResource>>(tariffUnitCosts);
                return Ok(mappedResource);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }

}