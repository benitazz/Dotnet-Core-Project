using MedicalBilingBackEnd.Persistence.EntityConfigurations.Lookups;
using MedicalBilingBackEnd.Persistence.EntityConfigurations.Tariffs;
using MedicalBilingMicroservice.Persistence.EntityConfigurations.Users;
using Microsoft.EntityFrameworkCore;

namespace MedicalBilingBackEnd.Common.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Users
            modelBuilder.ApplyConfiguration(new ApplicationRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationUserRoleConfiguration());

            // Lookups
            modelBuilder.ApplyConfiguration(new FileStatusConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceStatusConfiguration());
            modelBuilder.ApplyConfiguration(new TariffTypeConfiguration());
            modelBuilder.ApplyConfiguration(new VatConfiguration());

            //Tariffs
            modelBuilder.ApplyConfiguration(new TariffConfiguration());
            modelBuilder.ApplyConfiguration(new TariffUnitCostConfiguration());
        }
    }
}