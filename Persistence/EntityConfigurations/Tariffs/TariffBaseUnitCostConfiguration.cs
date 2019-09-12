using MedicalEngineMicroService.Common;
using MedicalEngineMicroService.Common.Extensions;
using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalEngineMicroService.Persistence.EntityConfigurations.Tariffs {
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

            builder.Property (tariffUnitCost => tariffUnitCost.UnitPrice)
                .HasColumnType (Constants.MoneyFormat);

            /*builder.Property (tariffUnitCost => tariffUnitCost.VatAmount)
                .HasColumnType (Constants.MoneyFormat);*/
        }
    }
}