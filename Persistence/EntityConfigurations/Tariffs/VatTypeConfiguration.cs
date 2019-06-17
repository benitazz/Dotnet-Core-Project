using System;
using MedicalBilingBackEnd.Common;
using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingBackEnd.Persistence.EntityConfigurations.Tariffs {
    public class VatTypeConfiguration : IEntityTypeConfiguration<VatType> {
        public void Configure (EntityTypeBuilder<VatType> builder) {
            builder.ConfigureEntity ();

            builder.Property (vatType => vatType.Percentage)
                .HasColumnType (Constants.PercentageFormat);

            builder.Property (vatType => vatType.Description)
                .HasMaxLength (255);

            this.SeedTariffTypes (builder);
        }

        private void SeedTariffTypes (EntityTypeBuilder<VatType> modelBuilder) {
            modelBuilder.HasData (
                new VatType {
                    Id = 1,
                        Description = "14% Percent VAT",
                        Percentage = 0.14,
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new VatType {
                    Id = 2,
                        Description = "15% Percent VAT",
                        Percentage = 0.15,
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                });
        }
    }
}