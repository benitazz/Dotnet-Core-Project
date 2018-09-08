using System;
using FluentValidation;

/// <summary>
/// https://stackoverflow.com/questions/50042201/how-to-validate-a-list-of-guid-using-fluentvalidation
/// </summary>
namespace MedicalBilingMicroservice.Resources.Validations
{
    public class GuidValidator: AbstractValidator<Guid>
    {
        public GuidValidator()
        {
            RuleFor(x => x).NotEmpty();
        }        
    }
}