using MedicalEngineMicroService.Common.Extensions;
using MedicalEngineMicroService.Core.Models.Entities.Medical;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalEngineMicroService.Persistence.EntityConfigurations.Medical {
    public class SectionConfiguration : IEntityTypeConfiguration<Section> {
        public void Configure (EntityTypeBuilder<Section> builder) {
            builder.ConfigureLookup();
        }
    }
}