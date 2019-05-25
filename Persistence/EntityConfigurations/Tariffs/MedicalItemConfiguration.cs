using MedicalBilingBackEnd.Common;
using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Tariffs {
    public class MedicalItemConfiguration : IEntityTypeConfiguration<MedicalItem> {
        public void Configure (EntityTypeBuilder<MedicalItem> builder) {
            builder.ConfigureEntity ();
            
            builder.Property (item => item.Code)
                .HasMaxLength (10);

            builder.Property (item => item.FromDate)
                .IsRequired ()
                .HasColumnType (Constants.DateTime2Type);

            builder.Property (item => item.ToDate)
                .IsRequired ()
                .HasColumnType (Constants.DateTime2Type);

            builder.Property (item => item.Name)
                .HasMaxLength (255);

            builder.Property (item => item.Description)
                .HasMaxLength (255);
        }
    }
}