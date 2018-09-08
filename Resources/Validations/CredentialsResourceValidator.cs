using FluentValidation;
using MedicalBilingMicroservice.Resources.ApiToDomainResource;

namespace MedicalBilingMicroservice.Resources.Validations {
    public class CredentialsResourceValidator : AbstractValidator<CredentialsResource> {
        public CredentialsResourceValidator () {
            RuleFor (resource => resource.Username).NotEmpty ().WithMessage ("Username cannot be empty");
            RuleFor (resource => resource.Password).NotEmpty ().WithMessage ("Password cannot be empty");
            RuleFor (resource => resource.Password).Length (6, 12).WithMessage ("Password must be between 6 and 12 characters");
        }
    }
}