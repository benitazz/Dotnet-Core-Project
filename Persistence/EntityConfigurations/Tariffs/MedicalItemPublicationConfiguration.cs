using MedicalEngineMicroService.Common.Extensions;
using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalEngineMicroService.Persistence.EntityConfigurations.Tariffs {
    public class MedicalItemPublicationConfiguration : IEntityTypeConfiguration<MedicalItemPublication> {
        public void Configure (EntityTypeBuilder<MedicalItemPublication> builder) {
            builder.ConfigureEntity ();

            builder.Property(medicalItem => medicalItem.Description).IsRequired();

            builder.HasIndex (medicalItem => new { medicalItem.MedicalItemId, medicalItem.PublicationTypeId })
                .IsUnique (true);
        }
    }
}