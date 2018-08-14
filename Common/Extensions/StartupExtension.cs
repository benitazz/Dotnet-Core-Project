using Microsoft.Extensions.DependencyInjection;
using switch_api.Core;
using switch_api.Core.Repositories;
using switch_api.Persistence;
using switch_api.Persistence.Repositories;

namespace switch_api.Common.Extensions {
    public static class StartupExtension {
        public static IServiceCollection ConfigureServices (this IServiceCollection services) {
            // services.AddScoped<IRepository, Repository>();
            services.AddScoped<IUnitOfWork, UnitOfWork> ();

            return services;
        }
    }
}