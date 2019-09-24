using MedicalEngineMicroService.Common.Extensions;
using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalEngineMicroService.Persistence.EntityConfigurations.Tariffs {
    public class SectionConfiguration : IEntityTypeConfiguration<Section> {
        public void Configure (EntityTypeBuilder<Section> builder) {
            builder.ConfigureLookup();
        }
    }
}