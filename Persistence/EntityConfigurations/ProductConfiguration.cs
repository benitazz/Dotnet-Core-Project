using System;
using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalBilingMicroservice.Persistence.EntityConfigurations {
    public class ProductConfiguration : IEntityTypeConfiguration<Product> {
        public void Configure (EntityTypeBuilder<Product> builder) {
            builder.ConfigureEntity ();
            this.SeedProduct (builder);
        }

        private void SeedProduct (EntityTypeBuilder<Product> builder) {
            builder.HasData (
                new Product { Id = 1, Name = "Unknown", Strength = 0, PackSize = 0, ManufactureTypeId = 1 },
                new Product { Id = 2, Name = "Magna bloc back belt-8837", Strength = 0, PackSize = 1, ManufactureTypeId = 2 },
                new Product { Id = 3, Name = "Magna bloc elbow band-8839", Strength = null, PackSize = 1, ManufactureTypeId = 2 },
                new Product { Id = 4, Name = "Magna bloc head band-8838", Strength = null, PackSize = 1, ManufactureTypeId = 2 },
                new Product { Id = 5, Name = "Magna bloc knee band-8833", Strength = null, PackSize = 1, ManufactureTypeId = 2 },
                new Product { Id = 6, Name = "Magna bloc personal discs (3)-8798", Strength = null, PackSize = 1, ManufactureTypeId = 2 },
                new Product { Id = 7, Name = "Magna bloc wrist bands (2)-8830", Strength = null, PackSize = 1, ManufactureTypeId = 2 },
                new Product { Id = 8, Name = "Magna bloc skin prep towels(16)-9605", Strength = null, PackSize = 1, ManufactureTypeId = 2 },
                new Product { Id = 9, Name = "Magna bloc adhes applic (60tapes)-892", Strength = null, PackSize = 1, ManufactureTypeId = 2 },
                new Product { Id = 10, Name = "Terranetic pillow mat", Strength = null, PackSize = 1, ManufactureTypeId = 3 }

            );
        }
    }
}