using MedicalBilingBackEnd.Common;
using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingBackEnd.Persistence.EntityConfigurations.Tariffs {
    public class TariffConfiguration : IEntityTypeConfiguration<Tariff> {
        public void Configure (EntityTypeBuilder<Tariff> builder) {
            builder.ConfigureEntity ();
            builder.Property (tariff => tariff.ValidFrom)
                .IsRequired ()
                .HasColumnType (Constants.DateTime2Type);

            builder.Property (tariff => tariff.ValidTo)
                .IsRequired ()
                .HasColumnType (Constants.DateTime2Type);
            

            /*builder.Property (tariff => tariff.TariffUnitCostId)
                .HasR ()
                .HasColumnType (Constants.DateTime2Type);*/
        }
    }
}