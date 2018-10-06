using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingBackEnd.Persistence.EntityConfigurations.Tariffs
{
    public class TariffConfiguration : IEntityTypeConfiguration<Tariff>
    {
        public void Configure(EntityTypeBuilder<Tariff> builder)
        {
            builder.ConfigureEntity();
            /*builder.HasMany(tariff => tariff.TariffUnitCostS)
                .WithOne(tariffUnitCost => tariffUnitCost.Tariff);*/

            builder.Property(t => t.Code)
                .HasMaxLength(10);
        }
    }
}