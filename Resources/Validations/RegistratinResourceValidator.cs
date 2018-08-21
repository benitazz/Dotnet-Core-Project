using FluentValidation;
using MedicalBilingMicroservice.Resources.ApiToDomainResource;

namespace MedicalBilingMicroservice.Resources.Validations {
    public class RegistratinResourceValidator : AbstractValidator<RegistrationResource> {
        public RegistratinResourceValidator () {
            RuleFor (resource => resource.Email).NotEmpty ().WithMessage ("Email cannot be empty");
            RuleFor (resource => resource.Password).NotEmpty ().WithMessage ("Password cannot be empty");
            RuleFor (resource => resource.FirstName).NotEmpty ().WithMessage ("FirstName cannot be empty");
            RuleFor (resource => resource.LastName).NotEmpty ().WithMessage ("LastName cannot be empty");
        }
    }
}