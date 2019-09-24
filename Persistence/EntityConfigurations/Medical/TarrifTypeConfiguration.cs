using System;
using MedicalEngineMicroService.Common;
using MedicalEngineMicroService.Common.Extensions;
using MedicalEngineMicroService.Core.Models.Entities.Medical;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalEngineMicroService.Persistence.EntityConfigurations.Medical
{
    public class TariffTypeConfiguration : IEntityTypeConfiguration<TariffType>
    {
        public void Configure(EntityTypeBuilder<TariffType> builder)
        {
            builder.ConfigureLookup();
                       
            this.SeedTariffTypes(builder);

        }

        private void SeedTariffTypes(EntityTypeBuilder<TariffType> modelBuilder)
        {
            modelBuilder.HasData(
                new TariffType
                {
                    Id = 1,
                    Name = Constants.Coida,
                    NormalizedName = Constants.Coida.ToUpper(),
                    Description = "Coid Tariffs",
                    NormalizedDescription = "COIDTARIFFS",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                },
                new TariffType
                {
                    Id = 2,
                    Name = Constants.NoneCoid,
                    NormalizedName = Constants.NoneCoid.ToUpper(),
                    Description = "None Coid Tariffs",
                    NormalizedDescription = "NONECOIDTARIFFS",
                    CreatedBy = Constants.Administrator,
                    CreatedDate = DateTime.Now,
                    UpdatedBy = Constants.Administrator,
                    UpdatedDate = DateTime.Now
                }
            );
        }

    }
}