using System;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using TinyCsvParser.TypeConverter;

namespace MedicalBilingBackEnd.Mapping.CsvMapping
{
    public class TariffMappingConverter : ITypeConverter<TariffBaseUnitCost>
    {
        public Type TargetType => typeof(TariffBaseUnitCost);

        public bool TryConvert(string value, out TariffBaseUnitCost result)
        {
            result = new TariffBaseUnitCost
            {
                ActualAmount = double.Parse(value)
            };
            return true;
        }
    }
}
