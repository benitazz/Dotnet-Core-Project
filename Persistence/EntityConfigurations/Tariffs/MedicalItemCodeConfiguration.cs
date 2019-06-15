using MedicalBilingBackEnd.Common;
using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Tariffs {
    public class MedicalItemCodeConfiguration : IEntityTypeConfiguration<MedicalItemCode> {
        public void Configure (EntityTypeBuilder<MedicalItemCode> builder) {
            builder.ToTable("MedicalItemCodes");
            builder.ConfigureEntity ();

            builder.Property (medicalItemCode => medicalItemCode.Code)
                .HasMaxLength (10);

            builder.Property (medicalItemCode => medicalItemCode.Name)
                .HasMaxLength (255);

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