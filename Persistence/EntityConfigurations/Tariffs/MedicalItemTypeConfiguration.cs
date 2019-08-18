using System;
using MedicalEngineMicroService.Common;
using MedicalEngineMicroService.Common.Extensions;
using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalEngineMicroService.Persistence.EntityConfigurations.Tariffs {
    public class MedicalItemTypeConfiguration : IEntityTypeConfiguration<MedicalItemType> {

        public void Configure (EntityTypeBuilder<MedicalItemType> builder) {
            builder.ConfigureLookup ();

            builder.Property (t => t.Name)
                .IsRequired ()
                .HasMaxLength (10);

            SeedPublicationType (builder);
        }

        private void SeedPublicationType (EntityTypeBuilder<MedicalItemType> modelBuilder) {
            modelBuilder.HasData (
                new MedicalItemType {
                    Id = 1,
                        Name = "-",
                        Description = "Unknown",
                        NormalizedName ="-",
                        NormalizedDescription ="UNKNOWN",
                        IsDeleted = false,
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new MedicalItemType {
                    Id = 2,
                        Name = "IT",
                        NormalizedName = "IT",
                        Description = "Treatment or Procedure Code",
                        NormalizedDescription ="TREATMENTORPROCEDURECODE",
                        IsDeleted = true,
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new MedicalItemType {
                    Id = 3,
                        Name = "ID",
                        NormalizedName ="ID",
                        Description = "Drug or Pharmaceutical Item (NAPPI)",
                        NormalizedDescription = "DRUGORPHARMACEUTICALITEM(NAPPI)",
                        IsDeleted = true,
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new MedicalItemType {
                    Id = 4,
                        Name = "M",
                        NormalizedName = "M",
                        Description = "Modifier",
                        NormalizedDescription = "MODIFIER",
                        IsDeleted = false,
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new MedicalItemType {
                    Id = 5,
                        Name = "R",
                        NormalizedName = "R",
                        Description = "Rule",
                        NormalizedDescription = "RULE",
                        IsDeleted = false,
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new MedicalItemType {
                    Id = 6,
                        Name = "N",
                        NormalizedName = "N",
                        Description = "Note",
                        NormalizedDescription = "NOTE",
                        IsDeleted = false,
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                }
            );
        }
    }
}