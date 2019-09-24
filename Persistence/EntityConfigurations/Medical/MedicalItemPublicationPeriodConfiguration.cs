using MedicalEngineMicroService.Common.Extensions;
using MedicalEngineMicroService.Core.Models.Entities.Medical;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalEngineMicroService.Persistence.EntityConfigurations.Medical {
    public class MedicalItemPublicationPeriodConfiguration : IEntityTypeConfiguration<MedicalItemPublicationPeriod> {
        public void Configure (EntityTypeBuilder<MedicalItemPublicationPeriod> builder) {
            builder.ConfigureEntity ();
        }
    }
}