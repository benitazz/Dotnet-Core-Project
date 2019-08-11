using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Tariffs {
    public class NappiCodeTypeConfiguration : IEntityTypeConfiguration<NappiCodeType> {
        public void Configure (EntityTypeBuilder<NappiCodeType> builder) {
            builder.ConfigureEntity ();
            this.SeedNappiCodeTypes (builder);
        }

        private void SeedNappiCodeTypes (EntityTypeBuilder<NappiCodeType> modelBuilder) {
            modelBuilder.HasData (
                new NappiCodeType { Id = 1, ProductId = 1, DosageTypeId = 1, NappiCode = "Unknown" },
                new NappiCodeType { Id = 2, ProductId = 2, DosageTypeId = 1, NappiCode = "100001" },
                new NappiCodeType { Id = 3, ProductId = 3, DosageTypeId = 1, NappiCode = "100008" },
                new NappiCodeType { Id = 4, ProductId = 4, DosageTypeId = 1, NappiCode = "100016" },
                new NappiCodeType { Id = 5, ProductId = 5, DosageTypeId = 1, NappiCode = "100024" },
                new NappiCodeType { Id = 6, ProductId = 6, DosageTypeId = 1, NappiCode = "100032" },
                new NappiCodeType { Id = 7, ProductId = 7, DosageTypeId = 1, NappiCode = "100039" },
                new NappiCodeType { Id = 8, ProductId = 8, DosageTypeId = 2, NappiCode = "100040" },
                new NappiCodeType { Id = 9, ProductId = 9, DosageTypeId = 3, NappiCode = "100047" },
                new NappiCodeType { Id = 10, ProductId = 10, DosageTypeId = 1, NappiCode = "100055" }
            );
        }
    }
}