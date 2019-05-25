using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities.Doctors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Doctors {
    public class PractionerConfiguration : IEntityTypeConfiguration<Practioner> {
        public void Configure (EntityTypeBuilder<Practioner> builder) {
            builder.ConfigureEntity();
        }
    }
}