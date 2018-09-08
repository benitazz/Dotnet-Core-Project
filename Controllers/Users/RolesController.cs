using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MedicalBilingMicroservice.Common.Helpers;
using MedicalBilingMicroservice.Core.Models.Entities.Users;
using MedicalBilingMicroservice.Resources.DomainToApiResource;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MedicalBilingMicroservice.Controllers.Users {

    [Route ("api/[controller]")]
    public class RolesController : Controller {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IMapper _mapper;

        public RolesController (RoleManager<ApplicationRole> UserManager, IMapper mapper) {
            this._roleManager = UserManager;
            this._mapper = mapper;
        }

        [HttpGet]
        [AllowAnonymous]
        // [Route ("Role", Name = "Role")]
        public async Task<IActionResult> GetAll () {
            try {
                var roles = this._roleManager.Roles.ToList ();

                var roleResources = this._mapper.Map<List<ApplicationRole>, List<ApplicationRoleResource>> (roles);

                return Ok (roleResources);
            } catch (Exception ex) {
                return StatusCode (StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}