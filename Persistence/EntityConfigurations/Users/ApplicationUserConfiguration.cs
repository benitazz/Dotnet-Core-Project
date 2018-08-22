using MedicalBilingMicroservice.Core.Models.Entities.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Users
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(t => t.CreatedDate)
               .IsRequired()
               .HasColumnType("Date")
               .HasDefaultValueSql("GetDate()");

            builder.Property(t => t.UpdatedBy)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(t => t.UpdatedDate)
               .IsRequired()
               .HasColumnType("Date")
               .HasDefaultValueSql("GetDate()");
        }
    }
}