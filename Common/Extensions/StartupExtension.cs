using MedicalEngineMicroService.Common.Helpers;
using MedicalEngineMicroService.Common.Helpers.FileHelpers;
using MedicalEngineMicroService.Core.Repositories.Lookups;
using MedicalEngineMicroService.Core.Repositories.Tariffs;
using MedicalEngineMicroService.Persistence.Repositories.Lookups;
using MedicalEngineMicroService.Persistence.Repositories.Tariffs;
using MedicalEngineMicroService.Common.Auth;
using MedicalEngineMicroService.Common.Helpers.RenderViews;
using MedicalEngineMicroService.Core;
using MedicalEngineMicroService.Core.Repositories;
using MedicalEngineMicroService.Persistence;
using MedicalEngineMicroService.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace MedicalEngineMicroService.Common.Extensions
{
    public static class StartupExtension {
        public static IServiceCollection ConfigureServices (this IServiceCollection services) {
            services.AddScoped<IDosageTypeRepository, DosageTypeRepository> ();
            services.AddScoped<IFileStatusRepository, FileStatusRepository> ();
            services.AddSingleton<IJwtFactory, JwtFactory> ();

            services.AddScoped<IInvoiceStatusRepository, InvoiceStatusRepository> ();
            services.AddScoped<IMedicalItemRepository, MedicalItemRepository> ();
            services.AddScoped<IMedicalItemTypeRepository, MedicalItemTypeRepository> ();
            services.AddScoped<IMedicalItemPublicationRepository, MedicalItemDescriptionRepository> ();
            services.AddScoped<IMedicalItemPublicationPeriodRepository, MedicalItemPublicationPeriodRepository> ();
            services.AddScoped<IManufactureTypeRepository, ManufactureTypeRepository> ();
            services.AddScoped<INappiCodeRepository, NappiCodeRepository> ();

            services.AddScoped<IPublicationRepository, PublicationRepository> ();
            services.AddScoped<IPractitionerTypeRepository, PractitionerTypeRepository> ();
            services.AddScoped<IPractitionerPractitionerTypeRepository, PractitionerPractitionerTypeRepository> ();
            services.AddScoped<IPractitionerGroupTypeRepository, PractitionerGroupTypeRepository> ();
            services.AddScoped<IPractitionerRepository, PractitionerRepository> ();
            services.AddScoped<IProductRepository, ProductRepository> ();

            services.AddScoped<ISectionRepository, SectionRepository> ();
            services.AddScoped<ITariffTypeRepository, TariffTypeRepository> ();
            services.AddScoped<ITariffRepository, TariffRepository> ();
            services.AddScoped<ITariffBaseUnitCostRepository, TariffBaseUnitCostRepository> ();
            services.AddScoped<ITariffBaseUnitCostTypeRepository, TariffBaseUnitCostTypeRepository> ();

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