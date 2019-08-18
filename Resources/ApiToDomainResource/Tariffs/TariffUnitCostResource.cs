using System;

namespace MedicalEngineMicroService.Resources.ApiToDomainResource.Tariffs
{
    public class TariffUnitCostResource
    {
        public int Id { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public Double ActualAmount { get; set; }
        public Double VatAmount { get; set; }
        public int TariffId { get; set; }
        public int VatId { get; set; }
         public string ItemDescription { get; set; }
    }
}