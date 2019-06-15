using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Tariffs {
    public class SectionTypeConfiguration : IEntityTypeConfiguration<SectionType> {
        public void Configure (EntityTypeBuilder<SectionType> builder) {
            builder.ConfigureLookup();
        }
    }
}