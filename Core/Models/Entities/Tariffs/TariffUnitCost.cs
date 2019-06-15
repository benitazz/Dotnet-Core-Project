using System;

namespace MedicalBilingBackEnd.Core.Models.Entities.Tariffs
{
    public class TariffUnitCost: EntityBase
    {
        public int Id { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public Double ActualAmount { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}