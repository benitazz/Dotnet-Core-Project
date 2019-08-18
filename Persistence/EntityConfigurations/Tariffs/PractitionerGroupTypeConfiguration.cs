using System;
using MedicalEngineMicroService.Common;
using MedicalEngineMicroService.Common.Extensions;
using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalEngineMicroService.Persistence.EntityConfigurations.Tariffs {
    public class PractitionerGroupTypeConfiguration : IEntityTypeConfiguration<PractitionerGroupType> {
        public void Configure (EntityTypeBuilder<PractitionerGroupType> builder) {
            builder.ConfigureLookup ();
            SeedGroupType (builder);
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
                },
                new PractitionerGroupType {
                    Id = 4,
                        Name = "HOS",
                        Description = "HOS discipline",
                        NormalizedName = "HOS",
                        NormalizedDescription = "HOS DISCIPLINE",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new PractitionerGroupType {
                    Id = 5,
                        Name = "PHR",
                        Description = "PHR discipline",
                        NormalizedName = "PHR",
                        NormalizedDescription = "PHR DISCIPLINE",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new PractitionerGroupType {
                    Id = 6,
                        Name = "PRS",
                        Description = "PRS discipline",
                        NormalizedName = "PRS",
                        NormalizedDescription = "PRS DISCIPLINE",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new PractitionerGroupType {
                    Id = 7,
                        Name = "RAD",
                        Description = "RAD discipline",
                        NormalizedName = "RAD",
                        NormalizedDescription = "RAD DISCIPLINE",
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                }
            );
        }
    }
}