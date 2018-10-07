using FluentValidation;
using MedicalBilingBackEnd.Resources.ApiToDomainResource.Lookups;

namespace MedicalBilingBackEnd.Resources.Validations.Lookups
{
    public class SaveLookupValidator : AbstractValidator<SaveLookupResource>
    {
        public SaveLookupValidator()
        {
            RuleFor(resource => resource.Name)
                .NotEmpty().WithMessage("Name cannot be empty")
                .Length(3, 255).WithMessage("Name must at least be 3 characters and not more than 255 characters");
            RuleFor(resource => resource.Description)
                .NotEmpty().WithMessage("Description cannot be empty")
                .Length(3, 255).WithMessage("Name must at least be 3 characters and not more than 255 characters");
        }
    }
}