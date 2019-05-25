using System;
using MedicalBilingBackEnd.Common;
using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingBackEnd.Persistence.EntityConfigurations.Tariffs {
    public class VatConfiguration : IEntityTypeConfiguration<Vat> {
        public void Configure (EntityTypeBuilder<Vat> builder) {
            builder.ConfigureEntity ();

            builder.Property (t => t.Percentage)
                .HasColumnType (Constants.PercentageFormat);

            builder.Property (t => t.Description)
                .HasMaxLength (255);

            this.SeedTariffTypes (builder);
        }

        private void SeedTariffTypes (EntityTypeBuilder<Vat> modelBuilder) {
            modelBuilder.HasData (
                new Vat {
                    Id = 1,
                        Description = "14% Percent VAT",
                        Percentage = 0.14,
                        CreatedBy = Constants.Administrator,
                        CreatedDate = DateTime.Now,
                        UpdatedBy = Constants.Administrator,
                        UpdatedDate = DateTime.Now
                },
                new Vat {
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