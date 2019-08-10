using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Tariffs {
    public class NappiCodeTypeConfiguration : IEntityTypeConfiguration<NappiCodeType> {
        public void Configure(EntityTypeBuilder<NappiCodeType> builder)
        {
            
        }
    }
}