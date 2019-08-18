using MedicalEngineMicroService.Core.Models.Entities;
using MedicalEngineMicroService.Core.Models.Entities.Lookups;

namespace MedicalEngineMicroService.Core.Models.Entities
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