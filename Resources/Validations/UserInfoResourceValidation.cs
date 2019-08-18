using FluentValidation;
using MedicalEngineMicroService.Resources.ApiToDomainResource;

namespace MedicalEngineMicroService.Resources.Validations
{
    public class UserInfoResourceValidation:  AbstractValidator<UserInfoResource> {
        public UserInfoResourceValidation () {
            RuleFor (resource => resource.UserId).NotNull().WithMessage ("UserId cannot be null");
            RuleFor (resource => resource.UserId).NotEmpty ().WithMessage ("UserId cannot be empty");
            RuleFor (resource => resource.UserId).Length(16).WithMessage("Not Valid Guid");
        }
        
    }
}