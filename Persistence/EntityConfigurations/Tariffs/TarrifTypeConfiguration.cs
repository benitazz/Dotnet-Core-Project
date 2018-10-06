using System;
using MedicalBilingBackEnd.Common;
using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingBackEnd.Persistence.EntityConfigurations.Tariffs
{
    public class TariffTypeConfiguration : IEntityTypeConfiguration<TariffType>
    {
        public void Configure(EntityTypeBuilder<TariffType> builder)
        {
            builder.ConfigureLookup();
            /*builder.HasMany(tariffType => tariffType.Tariffs)
                 .WithOne(tariff => tariff.TariffType);*/
            
            this.SeedTariffTypes(builder);

        }

        private void SeedTariffTypes(EntityTypeBuilder<TariffType> modelBuilder)
        {
            modelBuilder.HasData(
                new TariffType
                {
                    Id = 1,
                    Name = "Chiropractor",
                    Description = "Chiropractor Tariffs",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                },
                new TariffType
                {
                    Id = 2,
                    Name = "Radiologist",
                    Description = "Radiologists Tariffs",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                },
                new TariffType
                {
                    Id = 3,
                    Name = "Dentist",
                    Description = "Dentists tarrifs",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                },
                new TariffType
                {
                    Id = 4,
                    Name = "Physiotherapist",
                    Description = "Physiotherapist tariffs",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                },
                new TariffType
                {
                    Id = 5,
                    Name = "Private Ambulance",
                    Description = "Private Ambulance Tariffs",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                },
                new TariffType
                {
                    Id = 6,
                    Name = "General Practioner",
                    Description = "General Practioner Tariffs",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                },
                new TariffType
                {
                    Id = 7,
                    Name = "Renal Care",
                    Description = "Renal Care Tariffs",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                },
                 new TariffType
                 {
                     Id = 8,
                     Name = "Social Worker",
                     Description = "Social Worker Tariffs",
                     CreatedBy = Constants.Administrator,
                     CreatedDate = DateTime.Now,
                     UpdatedBy = Constants.Administrator,
                     UpdatedDate = DateTime.Now
                 },
                  new TariffType
                  {
                      Id = 9,
                      Name = "Wound Care",
                      Description = "Wound Care Tariffs",
                      CreatedBy = Constants.Administrator,
                      CreatedDate = DateTime.Now,
                      UpdatedBy = Constants.Administrator,
                      UpdatedDate = DateTime.Now
                  }
            );
        }

    }
}