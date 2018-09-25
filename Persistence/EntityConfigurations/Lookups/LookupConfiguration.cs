
using MedicalBilingBackEnd.Core.Models.Entities.Lookups;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingBackEnd.Persistence.EntityConfigurations.Lookups
{
    public class LookupConfiguration<T> where T : Lookup, IEntityTypeConfiguration<T>
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(t => t.Name)
               .HasMaxLength(255);
        }
    }
}