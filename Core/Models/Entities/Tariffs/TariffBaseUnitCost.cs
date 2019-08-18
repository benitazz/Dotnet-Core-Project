using System;

namespace MedicalEngineMicroService.Core.Models.Entities.Tariffs
{
    public class TariffBaseUnitCost: EntityBase
    {
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public Double ActualAmount { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}