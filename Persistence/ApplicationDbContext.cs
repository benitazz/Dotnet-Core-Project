using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingBackEnd.Core.Models.Entities.Lookups;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using MedicalBilingMicroservice.Core.Models.Entities.Doctors;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using MedicalBilingMicroservice.Core.Models.Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedicalBilingMicroservice.Persistence {
    public class ApplicationDbContext:
        IdentityDbContext<ApplicationUser, ApplicationRole, string, IdentityUserClaim<string>, ApplicationUserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>> {

            public DbSet<FileStatus> FileStatuses { get; set; }
            public DbSet<InvoiceStatus> InvoiceStatuses { get; set; }
            public DbSet<MedicalItem> MedicalItems { get; set; }
            public DbSet<Practioner> Practioners { get; set; }
            public DbSet<Publication> Publications { get; set; }
            public DbSet<Tariff> Tariffs { get; set; }
            public DbSet<TariffType> TariffTypes { get; set; }
            public DbSet<TariffUnitCost> TariffUnitCosts { get; set; }
            public DbSet<Vat> Vats { get; set; }

            public ApplicationDbContext (DbContextOptions options) : base (options) {

            }

            protected override void OnModelCreating (ModelBuilder modelBuilder) {
                base.OnModelCreating (modelBuilder);
                modelBuilder.Seed ();
            }
        }
}