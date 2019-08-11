using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities.Lookups;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Lookups {
    public class ManufactureTypeConfiguration : IEntityTypeConfiguration<ManufactureType> {
        public void Configure (EntityTypeBuilder<ManufactureType> builder) {
            builder.ConfigureLookup ();
            SeedManufactureTypes (builder);
        }

        private void SeedManufactureTypes (EntityTypeBuilder<ManufactureType> modelBuilder) {
            modelBuilder.HasData (
                new ManufactureType {
                    Id = 1,
                        Name = "Unknown",
                        NormalizedName = "UNKNOWN",
                        Description = "Unknown",
                        NormalizedDescription = "UNKNOWN"
                },
                new ManufactureType {
                    Id = 2,
                        Name = "AMW",
                        NormalizedName = "AMW",
                        Description = "AMW",
                        NormalizedDescription = "AMW"
                },
                new ManufactureType {
                    Id = 3,
                        Name = "MGP",
                        NormalizedName = "MGP",
                        Description = "MGP",
                        NormalizedDescription = "MGP"
                }
            );
        }
    }
}