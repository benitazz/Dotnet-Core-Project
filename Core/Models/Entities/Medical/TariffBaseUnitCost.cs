using System;
using MedicalBilingMicroservice.Core.Models.Entities.Lookups;

namespace MedicalEngineMicroService.Core.Models.Entities.Medical {
    public class TariffBaseUnitCost : LookupDescriptionBase {
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public Double UnitPrice { get; set; }
        public int TariffBaseUnitCostTypeId { get; set; }
        public TariffBaseUnitCostType TariffBaseUnitCostType { get; set; }

    }
}