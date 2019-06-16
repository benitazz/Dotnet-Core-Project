using System;
using MedicalBilingBackEnd.Common;
using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Tariffs {
    public class PractitionerGroupTypeConfiguration : IEntityTypeConfiguration<PractitionerGroupType> {
        public void Configure (EntityTypeBuilder<PractitionerGroupType> builder) {
            builder.ConfigureLookup ();
            SeedGroupType(builder);
        }

        private void SeedGroupType (EntityTypeBuilder<PractitionerGroupType> modelBuilder) {
            modelBuilder.HasData (
                new PractitionerGroupType {
                    Id = 1,
                        Name = "ALL",
                        Description = "ALL discipline",
                        NormalizedName = "ALL",
                        NormalizedDescription = "ALL DISCIPLINE",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new PractitionerGroupType {
                    Id = 2,
                        Name = "SPC",
                        Description = "SPC discipline",
                        NormalizedName = "SPC",
                        NormalizedDescription = "SPC DISCIPLINE",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new PractitionerGroupType {
                    Id = 3,
                        Name = "GPH",
                        Description = "GPH discipline",
                        NormalizedName = "GPH",
                        NormalizedDescription = "GPH DISCIPLINE",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                }
            );
        }
    }
}