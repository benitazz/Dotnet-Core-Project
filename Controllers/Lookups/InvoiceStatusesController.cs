using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MedicalEngineMicroService.Common.Attributes;
using MedicalEngineMicroService.Core.Models.Entities.Lookups;
using MedicalEngineMicroService.Core.Repositories.Lookups;
using MedicalEngineMicroService.Resources.DomainToApiResource.Lookups;
using Microsoft.AspNetCore.Mvc;

namespace MedicalEngineMicroService.Controllers.Lookups
{
    [Route("api/lookups/[controller]")]
    [SwaggerGroup("/api/lookups/InvoiceStatuses")]
    public class InvoiceStatusesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IInvoiceStatusRepository _invoiceStatusRepository;

        public InvoiceStatusesController(IMapper mapper,
                                         IInvoiceStatusRepository invoiceStatusRepository)
        {
            this._mapper = mapper;
            this._invoiceStatusRepository = invoiceStatusRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var invoiceStatus = await this._invoiceStatusRepository.Get(id);

            if (invoiceStatus == null)
            {
                return NotFound();
            }

            var mappedResource = this._mapper.Map<InvoiceStatus, LookupResource>(invoiceStatus);
            return Ok(mappedResource);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var invoiceStatuses = await this._invoiceStatusRepository.GetAll();

                if (invoiceStatuses == null)
                {
                    return NotFound();
                }

                var mappedResource = this._mapper.Map<List<InvoiceStatus>, List<LookupResource>>(invoiceStatuses);
                return Ok(mappedResource);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}