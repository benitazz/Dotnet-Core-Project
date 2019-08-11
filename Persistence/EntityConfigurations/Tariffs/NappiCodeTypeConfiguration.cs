using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations.Tariffs {
    public class NappiCodeTypeConfiguration : IEntityTypeConfiguration<NappiCodeType> {
        public void Configure (EntityTypeBuilder<NappiCodeType> builder) {
            builder.ConfigureEntity ();
           // this.SeedNappiCodeTypes (builder);
        }

        // private void SeedNappiCodeTypes (EntityTypeBuilder<NappiCodeType> modelBuilder) {
        //     modelBuilder.HasData (new NappiCodeType{Id =, NappiCode=, ProductName=, ProductStrength=, DosageFrom=, ProductPackSize=,ManufacturerCode=, Schedule=});
    }
}