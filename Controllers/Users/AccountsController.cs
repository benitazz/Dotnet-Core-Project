using System.Threading.Tasks;
using AutoMapper;
using MedicalBilingMicroservice.Common.Helpers;
using MedicalBilingMicroservice.Core.Models.Entities.Users;
using MedicalBilingMicroservice.Resources.ApiToDomainResource;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MedicalBilingMicroservice.Controllers.Users {

    [Route ("api/[controller]")]
    public class AccountsController : Controller {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public AccountsController (UserManager<ApplicationUser> UserManager, IMapper mapper) {
            _userManager = UserManager;
            this._mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Post ([FromBody] RegistrationResource registrationResource) {
            if (!ModelState.IsValid) {
                return BadRequest (ModelState);
            }

            var userIdentity = this._mapper.Map<ApplicationUser> (registrationResource);
            userIdentity.UpdatedBy = "test";
            var result = await this._userManager.CreateAsync (userIdentity, registrationResource.Password);

            if (!result.Succeeded) {
                return new BadRequestObjectResult (Errors.AddErrorsToModelState (result, ModelState));
            }

            return Ok ("Account created");
        }
    }
}