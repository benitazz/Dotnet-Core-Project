using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Tariffs {
    public class PractitionerPractitionerTypeConfiguration : IEntityTypeConfiguration<PractitionerPractitionerType> {
        public void Configure (EntityTypeBuilder<PractitionerPractitionerType> builder) {
            builder.ConfigureEntity ();
        }
    }
}