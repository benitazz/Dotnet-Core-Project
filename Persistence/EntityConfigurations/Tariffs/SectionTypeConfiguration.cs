using MedicalEngineMicroService.Common.Extensions;
using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalEngineMicroService.Persistence.EntityConfigurations.Tariffs {
    public class SectionTypeConfiguration : IEntityTypeConfiguration<SectionType> {
        public void Configure (EntityTypeBuilder<SectionType> builder) {
            builder.ConfigureLookup();
        }
    }
}