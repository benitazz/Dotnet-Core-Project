using System;
using System.Collections.Generic;

namespace MedicalBilingBackEnd.Core.Models.Entities.Tariffs
{
    public class Tariff : EntityBase
    {

        public int Id { get; set; }
        public string Code { get; set; }
        public int TariffTypeId { get; set; }
        public TariffType TariffType { get; set; }
        public virtual ICollection<TariffUnitCost> TariffUnitCostS { get; set; }
        public Tariff()
        {
            this.TariffUnitCostS = new HashSet<TariffUnitCost>();
        }

    }
}