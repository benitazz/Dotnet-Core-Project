using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Tariffs {
    public class PractitionerConfiguration : IEntityTypeConfiguration<Practitioner> {
        public void Configure (EntityTypeBuilder<Practitioner> builder) {
            builder.ConfigureLookup();
        }
    }
}