using MedicalEngineMicroService.Common.Extensions;
using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalEngineMicroService.Persistence.EntityConfigurations.Tariffs {
    public class PractitionerPractitionerTypeConfiguration : IEntityTypeConfiguration<PractitionerPractitionerType> {
        public void Configure (EntityTypeBuilder<PractitionerPractitionerType> builder) {
            builder.ConfigureEntity ();
        }
    }
}