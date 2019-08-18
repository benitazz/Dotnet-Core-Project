using FluentValidation;
using MedicalEngineMicroService.Resources.ApiToDomainResource.Lookups;
using MedicalEngineMicroService.Resources.Validations.Lookups;
using MedicalEngineMicroService.Resources.ApiToDomainResource;
using MedicalEngineMicroService.Resources.Validations;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalEngineMicroService.Common.Extensions {
    public static class ResourceValidationExtensions {
        public static IServiceCollection ConfigureValidationServices (this IServiceCollection services) {
            services.AddTransient<IValidator<CredentialsResource>, CredentialsResourceValidator> ();
            services.AddTransient<IValidator<RegistrationResource>, RegistratinResourceValidator> ();
            services.AddTransient<IValidator<UserInfoResource>, UserInfoResourceValidation> ();
            services.AddTransient<IValidator<SaveLookupResource>, SaveLookupValidator>();
            return services;
        }
    }
}