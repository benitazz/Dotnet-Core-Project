using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Tariffs {
    public class MedicalItemCodeDescriptionConfiguration : IEntityTypeConfiguration<MedicalItemCodeDescription> {
        public void Configure (EntityTypeBuilder<MedicalItemCodeDescription> builder) {
            builder.ConfigureEntity ();
        }
    }
}