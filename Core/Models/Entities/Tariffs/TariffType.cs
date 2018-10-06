using System.Collections.Generic;
using MedicalBilingBackEnd.Core.Models.Entities.Lookups;

namespace MedicalBilingBackEnd.Core.Models.Entities.Tariffs
{
    public class TariffType : Lookup
    {
        public virtual ICollection<Tariff> Tariffs { get; set; }
        public TariffType()
        {
             this.Tariffs = new HashSet<Tariff>();
        }
    }
}