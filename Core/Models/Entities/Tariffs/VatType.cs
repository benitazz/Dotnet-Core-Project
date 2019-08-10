using System;

namespace MedicalBilingBackEnd.Core.Models.Entities.Tariffs
{
    public class VatType: EntityBase
    {
        public Double Percentage { get; set; }
        public string Description { get; set; }

        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
    }
}