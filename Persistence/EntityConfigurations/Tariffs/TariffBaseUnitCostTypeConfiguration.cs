using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Tariffs {
    public class TariffBaseUnitCostTypeConfiguration : IEntityTypeConfiguration<TariffBaseUnitCostType> {
        public void Configure (EntityTypeBuilder<TariffBaseUnitCostType> builder) {
            builder.ConfigureLookup ();
        }
    }
}