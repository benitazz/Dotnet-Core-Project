using FluentValidation;
using MedicalEngineMicroService.Resources.ApiToDomainResource;

namespace MedicalEngineMicroService.Resources.Validations {
    public class RegistratinResourceValidator : AbstractValidator<RegistrationResource> {
        public RegistratinResourceValidator () {
            RuleFor (resource => resource.Email).NotEmpty ().WithMessage ("Email cannot be empty");
            RuleFor (resource => resource.Password).NotEmpty ().WithMessage ("Password cannot be empty");
            RuleFor (resource => resource.FirstName).NotEmpty ().WithMessage ("FirstName cannot be empty");
            RuleFor (resource => resource.LastName).NotEmpty ().WithMessage ("LastName cannot be empty");
            RuleFor (resource => resource.PracticeNumber).Matches(@"\A\S{10,15}\z").WithMessage ("Invalid practice number");
        }
    }
}