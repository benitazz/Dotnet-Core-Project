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
                .IsRequired ();

            SeedMedicalItem (builder);
        }

        private void SeedMedicalItem (EntityTypeBuilder<MedicalItem> modelBuilder) {
            modelBuilder.HasData (
                new MedicalItem { Id = 1, Code = "0002", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 2, Code = "0004", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 3, Code = "0005", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 4, Code = "0006", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 5, Code = "0007", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 6, Code = "0008", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 7, Code = "0009", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 8, Code = "0010", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 9, Code = "0011", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 10, Code = "0013", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 11, Code = "0014", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 12, Code = "0015", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 13, Code = "0017", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 14, Code = "0018", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 15, Code = "0019", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 16, Code = "0046", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 17, Code = "0047", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 18, Code = "0048", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 19, Code = "0049", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 20, Code = "0050", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 21, Code = "0051", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 22, Code = "0053", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 23, Code = "0055", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 24, Code = "0057", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 25, Code = "0058", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 26, Code = "0061", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 27, Code = "0063", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 28, Code = "0064", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 29, Code = "0065", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 30, Code = "0066", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 31, Code = "0067", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 32, Code = "0069", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 33, Code = "0070", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 34, Code = "0072", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 35, Code = "0073", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 36, Code = "0074", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 37, Code = "0075", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 38, Code = "0077", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 39, Code = "0078", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 40, Code = "0079", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 41, Code = "0080", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 42, Code = "0081", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 43, Code = "0082", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 44, Code = "0083", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 45, Code = "0084", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 46, Code = "0085", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 47, Code = "0086", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 48, Code = "0090", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 49, Code = "0091", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 50, Code = "0092", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 51, Code = "0095", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 52, Code = "0096", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 53, Code = "0097", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 54, Code = "0160", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 55, Code = "0165", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 56, Code = "5104", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 57, Code = "6100", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 58, Code = "6101", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 59, Code = "6102", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 60, Code = "6103", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 61, Code = "6104", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 62, Code = "6105", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 63, Code = "6106", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 64, Code = "6107", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 65, Code = "6108", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 66, Code = "6109", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 67, Code = "6110", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 68, Code = "6300", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 69, Code = "6301", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 70, Code = "6302", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 71, Code = "6303", MedicalItemTypeId = 4 },
                new MedicalItem { Id = 72, Code = "6305", MedicalItemTypeId = 4 }
            );
        }
    }
}