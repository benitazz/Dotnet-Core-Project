using MedicalBilingBackEnd.Persistence.EntityConfigurations.Lookups;
using MedicalBilingBackEnd.Persistence.EntityConfigurations.Tariffs;
using MedicalBilingMicroservice.Persistence.EntityConfigurations;
using MedicalBilingMicroservice.Persistence.EntityConfigurations.Lookups;
using MedicalBilingMicroservice.Persistence.EntityConfigurations.Tariffs;
using MedicalBilingMicroservice.Persistence.EntityConfigurations.Users;
using Microsoft.EntityFrameworkCore;

namespace MedicalBilingBackEnd.Common.Extensions {
    public static class ModelBuilderExtensions {
        public static void Seed (this ModelBuilder modelBuilder) {
            // Users
            modelBuilder.ApplyConfiguration (new ApplicationRoleConfiguration ());
            modelBuilder.ApplyConfiguration (new ApplicationUserConfiguration ());
            modelBuilder.ApplyConfiguration (new ApplicationUserRoleConfiguration ());

            // Lookups
            modelBuilder.ApplyConfiguration (new FileStatusConfiguration ());
            modelBuilder.ApplyConfiguration (new InvoiceStatusConfiguration ());
            modelBuilder.ApplyConfiguration (new TariffTypeConfiguration ());
            modelBuilder.ApplyConfiguration (new VatTypeConfiguration ());

            //Tariffs
            modelBuilder.ApplyConfiguration (new MedicalItemConfiguration ());
            modelBuilder.ApplyConfiguration (new MedicalItemPublicationConfiguration ());
            modelBuilder.ApplyConfiguration (new MedicalItemTypeConfiguration ());
            modelBuilder.ApplyConfiguration (new MedicalItemPublicationPeriodConfiguration ());
            modelBuilder.ApplyConfiguration (new ManufactureTypeConfiguration ());
            modelBuilder.ApplyConfiguration (new NappiCodeTypeConfiguration ());

            modelBuilder.ApplyConfiguration (new SectionTypeConfiguration ());

            modelBuilder.ApplyConfiguration (new PublicationTypeConfiguration ());
            modelBuilder.ApplyConfiguration (new PractitionerTypeConfiguration ());
            modelBuilder.ApplyConfiguration (new PractitionerGroupTypeConfiguration ());
            modelBuilder.ApplyConfiguration (new PractitionerPractitionerTypeConfiguration ());
            modelBuilder.ApplyConfiguration (new PractitionerConfiguration ());
            modelBuilder.ApplyConfiguration (new ProductConfiguration ());

            modelBuilder.ApplyConfiguration (new TariffConfiguration ());
            modelBuilder.ApplyConfiguration (new TariffBaseUnitCostConfiguration ());
            modelBuilder.ApplyConfiguration (new TariffBaseUnitCostTypeConfiguration ());
        }
    }
}