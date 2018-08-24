using MedicalBilingMicroservice.Core.Models.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Users
{
    public class ApplicationRoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            // builder.ToTable("tbl_AssetDevices");
            
            builder.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(t => t.CreatedBy)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(t => t.CreatedDate)
                .IsRequired()
                .HasColumnType("DATETIME")
                .HasDefaultValueSql("GetDate()");

            builder.Property(t => t.UpdatedBy)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(t => t.UpdatedDate)
               .IsRequired()
               .HasColumnType("DATETIME")
               .HasDefaultValueSql("GetDate()");
        }
    }
}