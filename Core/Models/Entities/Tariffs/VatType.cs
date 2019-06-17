using System;

namespace MedicalBilingBackEnd.Core.Models.Entities.Tariffs
{
    public class VatType: EntityBase
    {
        public int Id { get; set; }
        public Double Percentage { get; set; }
        public string Description { get; set; }
    }
}