using System;
using MedicalEngineMicroService.Core.Models.Entities.Lookups;
using MedicalEngineMicroService.Core.Models.Entities.Tariffs;

namespace MedicalEngineMicroService.Core.Models.Entities.Tariffs {
    public class Tariff : EntityBase {
        public Double RecommendedUnit { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public int TariffUnitCostId { get; set; }
        public TariffBaseUnitCost TariffUnitCost { get; set; }
        public int MedicalItemPublicationPeriodId { get; set; }
        public MedicalItemPublicationPeriod MedicalItemPublicationPeriod { get; set; }
        public int PractitionerTypeId { get; set; }
        public PractitionerType PractitionerType { get; set; }
        public int VatTypeId  { get; set; }
        public VatType VatType { get; set; }
    }
}