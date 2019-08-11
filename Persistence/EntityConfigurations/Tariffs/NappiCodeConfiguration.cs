using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Tariffs {
    public class NappiCodeConfiguration : IEntityTypeConfiguration<NappiCode> {
        public void Configure (EntityTypeBuilder<NappiCode> builder) {
            builder.ConfigureEntity ();
            this.SeedNappiCode (builder);
        }

        private void SeedNappiCode (EntityTypeBuilder<NappiCode> modelBuilder) {
            modelBuilder.HasData (
                new NappiCode { Id = 1, ProductId = 1, DosageTypeId = 1, Code = "Unknown" },
                new NappiCode { Id = 2, ProductId = 2, DosageTypeId = 1, Code = "100001" },
                new NappiCode { Id = 3, ProductId = 3, DosageTypeId = 1, Code = "100008" },
                new NappiCode { Id = 4, ProductId = 4, DosageTypeId = 1, Code = "100016" },
                new NappiCode { Id = 5, ProductId = 5, DosageTypeId = 1, Code = "100024" },
                new NappiCode { Id = 6, ProductId = 6, DosageTypeId = 1, Code = "100032" },
                new NappiCode { Id = 7, ProductId = 7, DosageTypeId = 1, Code = "100039" },
                new NappiCode { Id = 8, ProductId = 8, DosageTypeId = 2, Code = "100040" },
                new NappiCode { Id = 9, ProductId = 9, DosageTypeId = 3, Code = "100047" },
                new NappiCode { Id = 10, ProductId = 10, DosageTypeId = 1, Code = "100055" }
            );
        }
    }
}