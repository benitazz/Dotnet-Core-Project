using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities.Lookups;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Lookups {
    public class DosageTypeConfiguration : IEntityTypeConfiguration<DosageType> {
        public void Configure (EntityTypeBuilder<DosageType> builder) {
            builder.ConfigureLookup ();
            SeedDosageType(builder);
        }

        private void SeedDosageType (EntityTypeBuilder<DosageType> modelBuilder) {
            modelBuilder.HasData (
                new DosageType {
                    Id = 1,
                        Name = "ZZZ",
                        NormalizedDescription = "ZZZ",
                        Description = "ZZZ",
                        NormalizedName = "ZZZ"
                },
                new DosageType {
                    Id = 2,
                        Name = "GAU",
                        NormalizedDescription = "GAU",
                        Description = "GAU",
                        NormalizedName = "GAU"
                },
                new DosageType {
                    Id = 3,
                        Name = "PLA",
                        NormalizedDescription = "PLA",
                        Description = "PLA",
                        NormalizedName = "PLA"
                }

            );
        }
    }
}