using MedicalBilingBackEnd.Common;
using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingBackEnd.Persistence.EntityConfigurations.Tariffs {
    public class TariffUnitCostConfiguration : IEntityTypeConfiguration<TariffUnitCost> {
        public void Configure (EntityTypeBuilder<TariffUnitCost> builder) {
            builder.ConfigureEntity ();

            builder.Property (t => t.ValidFrom)
                .IsRequired ()
                .HasColumnType (Constants.DateTime2Type)
                .HasDefaultValueSql (Constants.DefaultSqlDate);

            builder.Property (t => t.ValidTo)
                .IsRequired ()
                .HasColumnType (Constants.DateTime2Type)
                .HasDefaultValueSql (Constants.DefaultSqlDate);

            builder.Property (t => t.ActualAmount)
                .HasColumnType (Constants.MoneyFormat);

            builder.Property (t => t.VatAmount)
                .HasColumnType (Constants.MoneyFormat);
        }
    }
}