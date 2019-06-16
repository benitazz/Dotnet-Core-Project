using System;
using MedicalBilingBackEnd.Common;
using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Tariffs {
    public class MedicalItemTypeConfiguration : IEntityTypeConfiguration<MedicalItemType> {

        public void Configure (EntityTypeBuilder<MedicalItemType> builder) {
            builder.ConfigureEntity ();

            builder.Property (t => t.Code)
                .IsRequired ()
                .HasMaxLength (10);

            builder.Property (t => t.Description)
                .IsRequired ()
                .HasMaxLength (255);

            SeedPublicationType(builder);
        }

        private void SeedPublicationType (EntityTypeBuilder<MedicalItemType> modelBuilder) {
            modelBuilder.HasData (
                new MedicalItemType {
                    Id = 1,
                        Code = "-",
                        Description = "Unknown",
                        IsDeleted = false,
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new MedicalItemType {
                    Id = 2,
                        Code = "IT",
                        Description = "Treatment or Procedure Code",
                        IsDeleted = true,
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new MedicalItemType {
                    Id = 3,
                        Code = "ID",
                        Description = "Drug or Pharmaceutical Item (NAPPI)",
                        IsDeleted = true,
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new MedicalItemType {
                    Id = 4,
                        Code = "M",
                        Description = "Modifier",
                        IsDeleted = false,
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new MedicalItemType {
                    Id = 5,
                        Code = "R",
                        Description = "Rule",
                        IsDeleted = false,
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new MedicalItemType {
                    Id = 6,
                        Code = "N",
                        Description = "Note",
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