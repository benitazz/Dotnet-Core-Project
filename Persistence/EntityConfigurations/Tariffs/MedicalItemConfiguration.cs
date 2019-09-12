using MedicalEngineMicroService.Common.Extensions;
using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalEngineMicroService.Persistence.EntityConfigurations.Tariffs {
    public class MedicalItemConfiguration : IEntityTypeConfiguration<MedicalItem> {
        public void Configure (EntityTypeBuilder<MedicalItem> builder) {
            builder.ConfigureEntity ();

            builder.Property (medicalItem => medicalItem.Code)
                .HasMaxLength (10)
                .IsRequired(); 
        }
    }
}