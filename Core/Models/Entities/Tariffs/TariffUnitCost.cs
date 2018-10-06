using System;

namespace MedicalBilingBackEnd.Core.Models.Entities.Tariffs
{
    public class TariffUnitCost: EntityBase
    {
        public int Id { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public Double ActualAmount { get; set; }
        public Double VatAmount { get; set; }
        public int TariffId { get; set; }
        public Tariff Tariff { get; set; }
        public int VatId { get; set; }
        public Vat Vat { get; set; }
        public string ItemDescription { get; set; }
    }
}