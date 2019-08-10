using MedicalBilingBackEnd.Common;
using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingBackEnd.Persistence.EntityConfigurations.Tariffs {
    public class TariffBaseUnitCostConfiguration : IEntityTypeConfiguration<TariffBaseUnitCost> {
        public void Configure (EntityTypeBuilder<TariffBaseUnitCost> builder) {
            builder.ConfigureEntity ();

            builder.Property (tariffUnitCost => tariffUnitCost.ValidFrom)
                .IsRequired ()
                .HasColumnType (Constants.DateTime2Type)
                .HasDefaultValueSql (Constants.DefaultSqlDate);

            builder.Property (tariffUnitCost => tariffUnitCost.ValidTo)
                .IsRequired ()
                .HasColumnType (Constants.DateTime2Type)
                .HasDefaultValueSql (Constants.DefaultSqlDate);

            builder.Property (tariffUnitCost => tariffUnitCost.ActualAmount)
                .HasColumnType (Constants.MoneyFormat);

            /*builder.Property (tariffUnitCost => tariffUnitCost.VatAmount)
                .HasColumnType (Constants.MoneyFormat);*/
        }
    }
}