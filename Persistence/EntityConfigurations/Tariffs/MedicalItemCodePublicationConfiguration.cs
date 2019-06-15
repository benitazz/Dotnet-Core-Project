using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Tariffs {
    public class MedicalItemCodePublicationConfiguration : IEntityTypeConfiguration<MedicalItemCodePublication> {
        public void Configure (EntityTypeBuilder<MedicalItemCodePublication> builder) {
            builder.ConfigureEntity ();
        }
    }
}