using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MedicalBilingBackEnd.Common.Attributes;
using MedicalBilingBackEnd.Core.Models.Entities.Lookups;
using MedicalBilingBackEnd.Core.Repositories.Lookups;
using MedicalBilingBackEnd.Resources.DomainToApiResource.Lookups;
using Microsoft.AspNetCore.Mvc;

namespace MedicalBilingBackEnd.Controllers.Lookups
{
    [Route("api/lookups/[controller]")]
    [SwaggerGroup("/api/lookups/FileStatuses")]
    public class FileStatusesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFileStatusRepository _fileStatusRepository;

        public FileStatusesController(IMapper mapper,
                                      IFileStatusRepository fileStatusRepository)
        {
            this._mapper = mapper;
            this._fileStatusRepository = fileStatusRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var fileStatus = await this._fileStatusRepository.Get(id);

            if (fileStatus == null)
            {
                return NotFound();
            }

            var mappedResource = this._mapper.Map<FileStatus, LookupResource>(fileStatus);
            return Ok(mappedResource);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var fileStatus = await this._fileStatusRepository.GetAll();

                if (fileStatus == null)
                {
                    return NotFound();
                }

                var mappedResource = this._mapper.Map<List<FileStatus>, List<LookupResource>>(fileStatus);
                return Ok(mappedResource);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}