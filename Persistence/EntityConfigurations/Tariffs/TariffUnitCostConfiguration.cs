using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingBackEnd.Persistence.EntityConfigurations.Tariffs
{
    public class TariffUnitCostConfiguration : IEntityTypeConfiguration<TariffUnitCost>
    {
        public void Configure(EntityTypeBuilder<TariffUnitCost> builder)
        {
            builder.ConfigureEntity();

            builder.Property(t => t.ValidFrom)
                   .IsRequired()
                   .HasColumnType("DATETIME2")
                   .HasDefaultValueSql("GetDate()");

            builder.Property(t => t.ValidTo)
                   .IsRequired()
                    .HasColumnType("DATETIME2")
                    .HasDefaultValueSql("GetDate()");

            builder.Property(t => t.ActualAmount)
                 .HasColumnType("DECIMAL(19,4)");

            builder.Property(t => t.VatAmount)
                .HasColumnType("DECIMAL(19,4)");
        }
    }
}