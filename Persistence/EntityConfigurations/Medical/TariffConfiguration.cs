using MedicalEngineMicroService.Common;
using MedicalEngineMicroService.Common.Extensions;
using MedicalEngineMicroService.Core.Models.Entities.Medical;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalEngineMicroService.Persistence.EntityConfigurations.Medical {
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