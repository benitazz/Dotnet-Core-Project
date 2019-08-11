using MedicalBilingBackEnd.Core.Models.Entities;
using MedicalBilingMicroservice.Core.Models.Entities.Lookups;

namespace MedicalBilingMicroservice.Core.Models.Entities
{
    public class Product: EntityBase
    {
        public string Name { get; set; }
        public double? Strength { get; set; }
        public int PackSize { get; set; }
        public int ManufactureTypeId { get; set; }
        public ManufactureType ManufactureType { get; set; }
    }
}