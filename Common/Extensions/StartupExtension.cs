using MedicalBilingBackEnd.Core.Repositories.Lookups;
using MedicalBilingBackEnd.Core.Repositories.Tariffs;
using MedicalBilingBackEnd.Persistence.Repositories.Lookups;
using MedicalBilingBackEnd.Persistence.Repositories.Tariffs;
using MedicalBilingMicroservice.Common.Auth;
using MedicalBilingMicroservice.Core;
using MedicalBilingMicroservice.Core.Repositories;
using MedicalBilingMicroservice.Persistence;
using MedicalBilingMicroservice.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalBilingMicroservice.Common.Extensions
{
    public static class StartupExtension
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IFileStatusRepository, FileStatusRepository>();
            services.AddSingleton<IJwtFactory, JwtFactory>();
            services.AddScoped<IInvoiceStatusRepository, InvoiceStatusRepository>();
            services.AddScoped<ITariffTypeRepository, TariffTypeRepository>();
            services.AddScoped<ITariffRepository, TariffRepository>();
            services.AddScoped<ITariffUnitCostRepository, TariffUnitCostRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IVatRepository, VatRepository>();

            return services;
        }
    }
}