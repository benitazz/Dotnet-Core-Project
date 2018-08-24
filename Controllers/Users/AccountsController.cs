using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MedicalBilingMicroservice.Common.Helpers;
using MedicalBilingMicroservice.Core.Models.Entities.Users;
using MedicalBilingMicroservice.Core.Repositories;
using MedicalBilingMicroservice.Resources.ApiToDomainResource;
using MedicalBilingMicroservicet.Resources.ApiToDomainResource;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MedicalBilingMicroservice.Controllers.Users
{

    [Route("api/[controller]")]
    public class AccountsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IEmailSender _emailSender;

        public AccountsController(UserManager<ApplicationUser> UserManager,
             IMapper mapper, IUserRepository userRepository,
             IEmailSender emailSender)
        {
            _userManager = UserManager;
            this._mapper = mapper;
            this._userRepository = userRepository;
            this._emailSender = emailSender;
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Post([FromBody] RegistrationResource registrationResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userIdentity = this._mapper.Map<ApplicationUser>(registrationResource);
            userIdentity.UpdatedBy = registrationResource.Email;
            var result = await this._userManager.CreateAsync(userIdentity, registrationResource.Password);

            if (!result.Succeeded)
            {
                return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));
            }

            var code = await _userManager.GenerateEmailConfirmationTokenAsync(userIdentity);
            var callbackUrl = Url.Action("ConfirmaEmail", "Account", new { userid = userIdentity.Id, token = code }, Request.Scheme);
            await _emailSender.SendEmailAsync(registrationResource.Email, callbackUrl, "Please confirm email");

            //  await _userManager.SignInAsync(user, isPersistent: false);
           // _logger.LogInformation("User created a new account with password.");

            return Ok("Account created");
        }

        [HttpGet]
		[AllowAnonymous]
		[Route("ConfirmEmail", Name="ConfirmEmail")]
		public async Task<IActionResult> ConfirmEmail(string userId, string code)
		{
			if (userId == null || code == null)
			{
				ModelState.AddModelError("error", "You need to provide your user id and confirmation code");
				return BadRequest(ModelState);
			}

            var user = await this._userManager.FindByIdAsync(userId);
			IdentityResult result = await this._userManager.ConfirmEmailAsync(user, code);

			if (result.Succeeded)
			{
				// return Redirect(Url.Content("~/account/registrationcomplete"));

                return Ok();
			}

			return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));
		}

		[HttpPost]
		[Route("ResendConfirmationEmail", Name = "ResendConfirmationEmail")]
		public async Task<IActionResult> ResendConfirmationEmail()
		{
			var user = await this._userManager.GetUserAsync(User);
			string code = await this._userManager.GenerateEmailConfirmationTokenAsync(user);
			var callbackUrl = Url.Link("ConfirmEmail", new { userId = user.Id, code = code });

			/*var notification = new AccountNotificationModel
			{
				Code = code,
				Url = callbackUrl,
				UserId = user.Id,
				Email = user.Email,
				DisplayName = user.UserName
			};

			string body = ViewRenderer.RenderView("~/Views/Mailer/NewAccount.cshtml", notification);*/
			await this._emailSender.SendEmailAsync(user.Id, "Medical account confirmation", callbackUrl);
			
			return Ok();
		}


        [HttpPost]
        [Route("DeleteAccount")]
        public async Task<IActionResult> DeleteAccount()
        {
            var user = await this._userManager.GetUserAsync(User);

            if (user == null)
            {
                return BadRequest();
            }

            IdentityResult result = await this._userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                return Ok();
            }

            return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            // https://stackoverflow.com/questions/51004516/net-core-2-1-identity-get-all-users-with-their-associated-roles
            var users = this._userManager.Users.Include(u => u.UserRoles).ThenInclude(ur => ur.Role).ToList();

            //var users = this._userRepository.GetAll();
            var userResources = _mapper.Map<IList<RegistrationResource>>(users);
            return Ok(userResources);
        }

        /// <summary>
        /// Set user password
        /// </summary>
        /// <param name="setPasswordResource">Set user password model</param>
        /// <returns>Http 400 or 200</returns>
        [Route("SetPassword")]
        public async Task<IActionResult> SetPassword(SetPasswordResource setPasswordResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await this._userManager.GetUserAsync(User);
            IdentityResult result = await this._userManager.AddPasswordAsync(user, setPasswordResource.NewPassword);

            if (result.Succeeded)
            {
                return Ok();
            }

            return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));
        }


        /// <summary>
        /// Change user password
        /// </summary>
        /// <param name="changePasswordResource">Change password model</param>
        /// <returns>Http 400 or 200</returns>
        [Route("ChangePassword")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordResource changePasswordResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Cannot change passwords for test users
            // Remove following lines for real usage
            if (User.IsInRole("Administrator") || User.Identity.Name == "user")
            {
                ModelState.AddModelError("Unable to change the password",
                 "Cannot change the admin password in this demo app. Remove lines in ChangePassword (AccountController) action for real usage");
                return BadRequest(ModelState);
            }

            var user = await this._userManager.GetUserAsync(User);

            IdentityResult result = await this._userManager.ChangePasswordAsync(user, changePasswordResource.OldPassword,
                changePasswordResource.NewPassword);
            if (result.Succeeded)
            {
                return Ok();
            }

            return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));
        }
    }
}