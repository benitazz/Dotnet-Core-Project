using MedicalBilingBackEnd.Persistence.EntityConfigurations.Lookups;
using MedicalBilingMicroservice.Persistence.EntityConfigurations.Users;
using Microsoft.EntityFrameworkCore;

namespace MedicalBilingBackEnd.Common.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApplicationRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationUserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new FileStatusConfiguration());
            modelBuilder.ApplyConfiguration(new InvoiceStatusConfiguration());
        }
    }
}