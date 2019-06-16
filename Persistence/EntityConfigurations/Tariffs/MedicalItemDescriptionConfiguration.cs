using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Tariffs {
    public class MedicalItemDescriptionConfiguration : IEntityTypeConfiguration<MedicalItemDescription> {
        public void Configure (EntityTypeBuilder<MedicalItemDescription> builder) {
            builder.ConfigureEntity ();
        }
    }
}