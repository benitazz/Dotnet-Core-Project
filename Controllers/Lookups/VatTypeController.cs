using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MedicalBilingBackEnd.Common.Attributes;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using MedicalBilingBackEnd.Core.Repositories.Lookups;
using MedicalBilingBackEnd.Resources.DomainToApiResource.Lookups;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicalBilingBackEnd.Controllers.Lookups
{
    [Route("api/lookups/[controller]")]
    [SwaggerGroup("/api/lookups/VatTypes")]
    public class VatTypeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IVatRepository _repository;

        public VatTypeController(
            IMapper mapper,
            IVatRepository repository)
        {
            this._mapper = mapper;
            this._repository = repository;
        }

        /// <summary>
        /// Get Vat type by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ///  <include file='../../wwwroot/comments.xml' path='XmlSummary/MyMembers[@name="getComment"]/*' />
        [HttpGet("{id}")]
        [EnableQuery]
        [ProducesResponseType(typeof(VatTypeResource), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var vatType = await this._repository.Get(id);

                if (vatType == null)
                {
                    return NotFound();
                }

                var mappedResource = this._mapper.Map<Vat, VatTypeResource>(vatType);
                return Ok(mappedResource);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        /// <summary>
        /// Get all VAT types
        /// </summary>
        /// <returns></returns>
        ///  <include file='../../wwwroot/comments.xml' path='XmlSummary/MyMembers[@name="getAllComment"]/*' />
        [HttpGet]
        [EnableQuery]
        [ProducesResponseType(typeof(List<VatTypeResource>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var vatTypes = await this._repository.GetAll();

                if (vatTypes == null)
                {
                    return Ok(new List<VatTypeResource>());
                }

                var mappedResource = this._mapper.Map<List<Vat>, List<VatTypeResource>>(vatTypes);
                return Ok(mappedResource);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}