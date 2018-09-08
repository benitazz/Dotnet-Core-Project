using FluentValidation;
using MedicalBilingMicroservice.Resources.ApiToDomainResource;
using MedicalBilingMicroservice.Resources.Validations;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalBilingMicroservice.Common.Extensions {
    public static class ResourceValidationExtensions {
        public static IServiceCollection ConfigureValidationServices (this IServiceCollection services) {
            services.AddTransient<IValidator<CredentialsResource>, CredentialsResourceValidator> ();
            services.AddTransient<IValidator<RegistrationResource>, RegistratinResourceValidator> ();
            services.AddTransient<IValidator<UserInfoResource>, UserInfoResourceValidation> ();
            return services;
        }
    }
}