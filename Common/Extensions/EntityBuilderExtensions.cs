using MedicalBilingBackEnd.Core.Models.Entities;
using MedicalBilingBackEnd.Core.Models.Entities.Lookups;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingBackEnd.Common.Extensions
{
    public static class EntityBuilderExtensions
    {
        public static void ConfigureEntity<T>(this EntityTypeBuilder<T> builder) where T: EntityBase
        {
            builder.Property(t => t.CreatedBy)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(t => t.CreatedDate)
                   .IsRequired()
                   .HasColumnType("DATETIME2")
                   .HasDefaultValueSql("GetDate()");

            builder.Property(t => t.UpdatedBy)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(t => t.UpdatedDate)
                   .IsRequired()
                   .HasColumnType("DATETIME2")
                   .HasDefaultValueSql("GetDate()");
        }

        public static void ConfigureLookup<T>(this EntityTypeBuilder<T> builder) where T: Lookup
        {
            ConfigureEntity(builder);

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(t => t.Description)
                   .HasMaxLength(255);
        }
    }
}