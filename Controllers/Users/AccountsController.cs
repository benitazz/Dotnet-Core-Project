using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using AutoMapper;
using MedicalBilingBackEnd.Common.Attributes;
using MedicalBilingMicroservice.Common.Helpers;
using MedicalBilingMicroservice.Core.Models.Entities.Users;
using MedicalBilingMicroservice.Core.Repositories;
using MedicalBilingMicroservice.Resources.ApiToDomainResource;
using MedicalBilingMicroservice.Resources.DomainToApiResource;
using MedicalBilingMicroservicet.Resources.ApiToDomainResource;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;

namespace MedicalBilingMicroservice.Controllers.Users
{

    [Route("api/users/[controller]")]
    [SwaggerGroup("/api/users/Accounts")]
    public class AccountsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IEmailSender _emailSender;

        public AccountsController(
            UserManager<ApplicationUser> UserManager,
            IMapper mapper,
            IUserRepository userRepository,
            IEmailSender emailSender)
        {
            _userManager = UserManager;
            this._mapper = mapper;
            this._userRepository = userRepository;
            this._emailSender = emailSender;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("Register", Name = "Register")]
        //[ApiVersionNeutral]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Post([FromBody] RegistrationResource registrationResource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var userIdentity = this._mapper.Map<ApplicationUser>(registrationResource);
                userIdentity.UpdatedBy = registrationResource.Email;
                var result = await this._userManager.CreateAsync(userIdentity, registrationResource.Password);

                if (!result.Succeeded)
                {
                    return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));
                }

                var code = await _userManager.GenerateEmailConfirmationTokenAsync(userIdentity);
                string codeHtmlVersion = HttpUtility.UrlEncode(code);

                var callbackUrl = Request.Scheme +
                    "://localhost:5000/api/Accounts/ConfirmEmail?userId=" +
                    userIdentity.Id + "&code=" + codeHtmlVersion;

                var htmlBody = "Hi " + userIdentity.Email +
                    "   You have been sent this email because you created an account on our website.  " +
                    "Please click on <a href =\"" + callbackUrl + "\">this link</a> to confirm your email address is correct. ";

                await _emailSender.SendEmailAsync(registrationResource.Email, "Please confirm email", htmlBody);

                // await _userManager.SignInAsync(user, isPersistent: false);
                // _logger.LogInformation("User created a new account with password.");

                return Ok("Account created");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("ConfirmEmail", Name = "ConfirmEmail")]
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

        /// <summary>
        ///     Get user info
        ///     401 if not authenticated
        /// </summary>
        /// <returns>The user info</returns>
        // [HostAuthentication(DefaultAuthenticationTypes.ExternalBearer)]
        [HttpGet]
        [Route("UserInfo")]
        public async Task<IActionResult> GetUserInfo(string userId)
        {
            try
            {
                var user = await this._userRepository.GetUserById(userId);

                if (user == null)
                {
                    return NotFound();
                }

                var userResource = this._mapper.Map<ApplicationUser, ApplicationUserResource>(user);
                return Ok(userResource);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        [EnableQuery]
        [Route("AllUsers", Name = "AllUsers")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var users = await this._userRepository.GetAllUsers();
                var userResources = this._mapper.Map<List<ApplicationUser>, List<ApplicationUserResource>>(users); ;
                return Ok(userResources);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Set user password
        /// </summary>
        /// <param name="setPasswordResource">Set user password model</param>
        /// <returns>Http 400 or 200</returns>
        [HttpPost]
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
        [HttpPost]
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
                    @"Cannot change the admin password in this demo app. 
                    Remove lines in ChangePassword (AccountController) action for real usage");
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

        /// <summary>
        /// Reset the user password
        /// </summary>
        /// <param name="resetPasswordResource">The code</param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [Route("ResetPassword", Name = "ResetPassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordResource resetPasswordResource)
        {
            if (ModelState.IsValid)
            {
                var user = await this._userManager.FindByEmailAsync(resetPasswordResource.Email);
                if (user == null)
                {
                    ModelState.AddModelError("", "No user found.");
                    return BadRequest(ModelState);
                }

                IdentityResult result =
                    await this._userManager.ResetPasswordAsync(
                        user,
                        resetPasswordResource.Code,
                        resetPasswordResource.Password
                    );

                if (result.Succeeded)
                {
                    return Ok();
                }

                return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));

                /*IHttpActionResult errorResult  = GetErrorResult(result);

				if (errorResult != null)
				{
					return errorResult;
				}*/
            }

            // If we got this far, something failed
            return BadRequest(ModelState);
        }

        /// <summary>
        /// If the user forget the password this action will send him a reset password mail
        /// </summary>
        /// <param name="model">The forgot password model</param>
        /// <returns>IHttpActionResult</returns>
        [HttpPost]
        [AllowAnonymous]
        [Route("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordResource model)
        {
            if (ModelState.IsValid)
            {
                var user = await this._userManager.FindByEmailAsync(model.Email);
                if (user == null || !(await this._userManager.IsEmailConfirmedAsync(user)))
                {
                    ModelState.AddModelError("", "The user either does not exist or is not confirmed.");
                    return BadRequest(ModelState);
                }

                string code = await this._userManager.GeneratePasswordResetTokenAsync(user);
                // var callbackUrl = Url.Content("~/account/resetpassword?email=") + HttpUtility.UrlEncode(model.Email) + "&code=" + HttpUtility.UrlEncode(code);

                /*var notification = new AccountNotificationModel
				{
					Url = callbackUrl,
					DisplayName = user.UserName
				};

				string body = ViewRenderer.RenderView("~/Views/Mailer/PasswordReset.cshtml", notification);
				await UserManager.SendEmailAsync(user.Id, "DurandalAuth reset password", body);*/

                return Ok();
            }

            // If we got this far, something failed
            return BadRequest(ModelState);
        }

        private IActionResult GetErrorResult(IdentityResult result)
        {
            /*if (result == null)
            {
            	return InternalServerError();
            }*/

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No errors in ModelState, return empty BadRequest
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }

    }
}