using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Tariffs {
    public class MedicalItemPublicationPeriodConfiguration : IEntityTypeConfiguration<MedicalItemPublicationPeriod> {
        public void Configure (EntityTypeBuilder<MedicalItemPublicationPeriod> builder) {
            builder.ConfigureEntity ();
        }
    }
}