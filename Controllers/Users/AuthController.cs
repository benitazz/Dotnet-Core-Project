using System.Security.Claims;
using System.Threading.Tasks;
using MedicalBilingBackEnd.Common.Attributes;
using MedicalBilingMicroservice.Common.Auth;
using MedicalBilingMicroservice.Common.Helpers;
using MedicalBilingMicroservice.Core.Models.Auth;
using MedicalBilingMicroservice.Core.Models.Entities.Users;
using MedicalBilingMicroservice.Resources.ApiToDomainResource;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace MedicalBilingMicroservice.Controllers.Users
{
    [Route("api/users/Auth")]
    [SwaggerGroup("/api/users/Auth")]
    public class AuthController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IJwtFactory _jwtFactory;
        private readonly IOptions<JwtIssuerOptions> _jwtOptions;

        public AuthController( UserManager<ApplicationUser> userManager,
                               IJwtFactory jwtFactory,
                               IOptions<JwtIssuerOptions> jwtOptions)
        {
            this._userManager = userManager;
            this._jwtFactory = jwtFactory;
            this._jwtOptions = jwtOptions;
        }

        // POST api/auth/login
        [HttpPost]
        [Route("Login", Name = "Login")]
        public async Task<IActionResult> Post([FromBody] CredentialsResource credentials)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var identity = await GetClaimsIdentity(credentials.Username, credentials.Password);
            if (identity == null)
            {
                return BadRequest(
                    Errors.AddErrorToModelState(
                    "login_failure",
                    "Invalid username or password.",
                     ModelState)
                    );
            }

            var jwt = await Tokens.GenerateJwt(
                identity,
                _jwtFactory,
                credentials.Username,
                _jwtOptions,
                new JsonSerializerSettings { Formatting = Formatting.Indented });

            return Ok(jwt);
        }
        private async Task<ClaimsIdentity> GetClaimsIdentity(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                return await Task.FromResult<ClaimsIdentity>(null);

            // get the user to verifty
            var userToVerify = await _userManager.FindByNameAsync(userName);

            if (userToVerify == null)
            {
                return await Task.FromResult<ClaimsIdentity>(null);
            }

            // check the credentials
            if (await _userManager.CheckPasswordAsync(userToVerify, password))
            {
                return await Task.FromResult(_jwtFactory.GenerateClaimsIdentity(userName, userToVerify.Id));
            }

            // Credentials are invalid, or account doesn't exist
            return await Task.FromResult<ClaimsIdentity>(null);
        }
    }
}