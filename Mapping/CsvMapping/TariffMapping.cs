using MedicalBilingBackEnd.Core;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using TinyCsvParser.Mapping;

namespace MedicalBilingBackEnd.Mapping.CsvMapping
{
    public class TariffMapping : CsvMapping<Tariff>
    {
        public 
        TariffMapping()
        {
            MapProperty(0, x => x.Code);
            MapProperty(1, x => x.TariffTypeId);
            MapProperty(2, x => x.TariffUnitCostS);
        }
    }
}