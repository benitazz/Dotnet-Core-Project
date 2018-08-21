using MedicalBilingMicroservice.Common.Auth;
using MedicalBilingMicroservice.Core;
using MedicalBilingMicroservice.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalBilingMicroservice.Common.Extensions
{
    public static class StartupExtension {
        public static IServiceCollection ConfigureServices (this IServiceCollection services) {
            services.AddSingleton<IJwtFactory, JwtFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork> ();
            return services;
        }
    }
}