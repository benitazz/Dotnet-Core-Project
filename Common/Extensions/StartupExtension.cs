using MedicalBilingBackEnd.Common.Helpers;
using MedicalBilingBackEnd.Common.Helpers.FileHelpers;
using MedicalBilingBackEnd.Core.Repositories.Lookups;
using MedicalBilingBackEnd.Core.Repositories.Tariffs;
using MedicalBilingBackEnd.Persistence.Repositories.Lookups;
using MedicalBilingBackEnd.Persistence.Repositories.Tariffs;
using MedicalBilingMicroservice.Common.Auth;
using MedicalBilingMicroservice.Common.Helpers.RenderViews;
using MedicalBilingMicroservice.Core;
using MedicalBilingMicroservice.Core.Repositories;
using MedicalBilingMicroservice.Core.Repositories.Doctors;
using MedicalBilingMicroservice.Core.Repositories.Tariffs;
using MedicalBilingMicroservice.Persistence;
using MedicalBilingMicroservice.Persistence.Repositories;
using MedicalBilingMicroservice.Persistence.Repositories.Doctors;
using MedicalBilingMicroservice.Persistence.Repositories.Tariffs;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalBilingMicroservice.Common.Extensions {
    public static class StartupExtension {
        public static IServiceCollection ConfigureServices (this IServiceCollection services) {
            services.AddScoped<IFileStatusRepository, FileStatusRepository> ();
            services.AddSingleton<IJwtFactory, JwtFactory> ();

            services.AddScoped<IInvoiceStatusRepository, InvoiceStatusRepository> ();
            services.AddScoped<IMedicalItemRepository, MedicalItemRepository> ();
            services.AddScoped<IMedicalItemTypeRepository, MedicalItemTypeRepository> ();
            services.AddScoped<IMedicalItemDescriptionRepository, MedicalItemDescriptionRepository> ();
            services.AddScoped<IMedicalItemPublicationRepository, MedicalItemPublicationRepository> ();
            services.AddScoped<IPublicationRepository, PublicationRepository> ();
            services.AddScoped<IPractionerRepository, PractionerRepository> ();
            services.AddScoped<ISectionTypeRepository, SectionTypeRepository> ();
            services.AddScoped<ITariffTypeRepository, TariffTypeRepository> ();
            services.AddScoped<ITariffRepository, TariffRepository> ();
            services.AddScoped<ITariffUnitCostRepository, TariffUnitCostRepository> ();

            services.AddScoped<IUnitOfWork, UnitOfWork> ();
            services.AddScoped<IUserRepository, UserRepository> ();
            services.AddScoped<IVatTypeRepository, VatTypeRepository> ();
            services.AddScoped<IViewRenderService, ViewRenderService> ();

            services.AddSingleton<IFileHelper, FileHelper> ();
            services.AddTransient<UserResolverService> ();

            return services;
        }
    }
}