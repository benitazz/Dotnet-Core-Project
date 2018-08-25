using MedicalBilingMicroservice.Common.Auth;
using MedicalBilingMicroservice.Core;
using MedicalBilingMicroservice.Core.Repositories;
using MedicalBilingMicroservice.Persistence;
using MedicalBilingMicroservice.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalBilingMicroservice.Common.Extensions {
    public static class StartupExtension {
        public static IServiceCollection ConfigureServices (this IServiceCollection services) {
            services.AddSingleton<IJwtFactory, JwtFactory> ();
            services.AddScoped<IUnitOfWork, UnitOfWork> ();
            services.AddScoped<IUserRepository, UserRepository> ();
            return services;
        }
    }
}