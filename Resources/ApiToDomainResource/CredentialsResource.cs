using System.ComponentModel.DataAnnotations;
using MedicalEngineMicroService.Resources.Validations;
using FluentValidation.Validators;
using FluentValidation.Attributes;

namespace MedicalEngineMicroService.Resources.ApiToDomainResource {

    //[Validator(typeof(CredentialsResourceValidator))]
    public class CredentialsResource {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}