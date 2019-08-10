using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Tariffs {
    public class MedicalItemPublicationConfiguration : IEntityTypeConfiguration<MedicalItemPublication> {
        public void Configure (EntityTypeBuilder<MedicalItemPublication> builder) {
            builder.ConfigureEntity ();

            builder.Property (medicalItem => medicalItem.Name)
                .HasMaxLength (255);

            builder.HasIndex (medicalItem => new { medicalItem.MedicalItemId, medicalItem.PublicationTypeId })
                .IsUnique (true);
        }
    }
}