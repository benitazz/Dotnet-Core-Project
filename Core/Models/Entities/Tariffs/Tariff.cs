using System;
using System.Collections.Generic;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;

namespace MedicalBilingBackEnd.Core.Models.Entities.Tariffs {
    public class Tariff : EntityBase {
        public int Id { get; set; }
        public int MedicalItemId { get; set; }
        public Double RecommendedUnit { get; set; }
        public MedicalItem MedicalItem { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public int TariffUnitCostId { get; set; }
        public TariffUnitCost TariffUnitCost { get; set; }
        /* public virtual ICollection<TariffUnitCost> TariffUnitCostS { get; set; }
         public Tariff () {
             this.TariffUnitCostS = new HashSet<TariffUnitCost> ();
         }*/

    }
}