using System.ComponentModel.DataAnnotations;
using MedicalBilingMicroservice.Resources.Validations;
using FluentValidation.Validators;
using FluentValidation.Attributes;

namespace MedicalBilingMicroservice.Resources.ApiToDomainResource {

    //[Validator(typeof(CredentialsResourceValidator))]
    public class CredentialsResource {
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}