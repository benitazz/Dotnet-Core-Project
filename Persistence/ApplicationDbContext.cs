using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingBackEnd.Core.Models.Entities.Lookups;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using MedicalBilingMicroservice.Core.Models.Entities;
using MedicalBilingMicroservice.Core.Models.Entities.Lookups;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using MedicalBilingMicroservice.Core.Models.Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedicalBilingMicroservice.Persistence {
    public class ApplicationDbContext:
        IdentityDbContext<ApplicationUser, ApplicationRole, string, IdentityUserClaim<string>, ApplicationUserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>> {

            public DbSet<DosageType> DosageTypes { get; set; }

            public DbSet<FileStatus> FileStatuses { get; set; }
            public DbSet<InvoiceStatus> InvoiceStatuses { get; set; }
            public DbSet<MedicalItem> MedicalItems { get; set; }
            public DbSet<MedicalItemType> MedicalItemTypes { get; set; }
            public DbSet<MedicalItemPublication> MedicalItemPublications { get; set; }
            public DbSet<MedicalItemPublicationPeriod> MedicalItemPublicationPeriods { get; set; }
            public DbSet<ManufactureType> ManufactureTypes { get; set; }

            public DbSet<NappiCodeType> NappiCodeTypes { get; set; }

            public DbSet<PractitionerType> PractitionerTypes { get; set; }
            public DbSet<PractitionerGroupType> PractitionerGroupTypes { get; set; }
            public DbSet<PractitionerPractitionerType> PractitionerPractitionerTypes { get; set; }
            public DbSet<Practitioner> Practitioners { get; set; }
            public DbSet<Product> Products { get; set; }
            public DbSet<PublicationType> PublicationTypes { get; set; }

            public DbSet<Tariff> Tariffs { get; set; }
            public DbSet<TariffType> TariffTypes { get; set; }
            public DbSet<TariffBaseUnitCost> TariffBaseUnitCosts { get; set; }
            public DbSet<TariffBaseUnitCostType> TariffBaseUnitCostTypes { get; set; }

            public DbSet<VatType> VatTypes { get; set; }
            public DbSet<SectionType> SectionTypes { get; set; }

            public ApplicationDbContext (DbContextOptions options) : base (options) {

            }

            protected override void OnModelCreating (ModelBuilder modelBuilder) {
                base.OnModelCreating (modelBuilder);
                modelBuilder.Seed ();
            }
        }
}