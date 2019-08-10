using MedicalBilingBackEnd.Common;
using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Tariffs {
    public class MedicalItemConfiguration : IEntityTypeConfiguration<MedicalItem> {
        public void Configure (EntityTypeBuilder<MedicalItem> builder) {
            builder.ConfigureEntity ();

            builder.Property (medicalItem => medicalItem.Code)
                .HasMaxLength (10);

            /* builder.Property (medicalItem => medicalItem.ValidFrom)
                .IsRequired ()
                .HasColumnType (Constants.DateTime2Type);

            builder.Property (medicalItem => medicalItem.ValidTo)
                .IsRequired ()
                .HasColumnType (Constants.DateTime2Type);
    
            builder.Property (medicalItem => medicalItem.Description)
                .HasMaxLength (255);*/
        }
    }
}