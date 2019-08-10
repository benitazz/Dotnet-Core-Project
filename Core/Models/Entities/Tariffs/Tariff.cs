using System;
using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;

namespace MedicalBilingBackEnd.Core.Models.Entities.Tariffs
{
    public class Tariff : EntityBase {
        public int MedicalItemId { get; set; }
        public Double RecommendedUnit { get; set; }
        public MedicalItem MedicalItem { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public int TariffUnitCostId { get; set; }
        public TariffBaseUnitCost TariffUnitCost { get; set; }
        /* public virtual ICollection<TariffUnitCost> TariffUnitCostS { get; set; }
         public Tariff () {
             this.TariffUnitCostS = new HashSet<TariffUnitCost> ();
         }*/

    }
}