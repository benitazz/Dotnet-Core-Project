using System;
using FluentValidation;

namespace MedicalBilingMicroservice.Resources.Validations
{
    /// <summary>
    /// https://stackoverflow.com/questions/50042201/how-to-validate-a-list-of-guid-using-fluentvalidation
    /// </summary>
    public class GuidValidator : AbstractValidator<Guid>
    {
        public GuidValidator()
        {
            RuleFor(x => x).NotEmpty();
        }
    }
}