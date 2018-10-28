using System;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using TinyCsvParser.TypeConverter;

namespace MedicalBilingBackEnd.Mapping.CsvMapping
{
    public class TariffMappingConverter : ITypeConverter<TariffUnitCost>
    {
        public Type TargetType => typeof(TariffUnitCost);

        public bool TryConvert(string value, out TariffUnitCost result)
        {
            result = new TariffUnitCost
            {
                ActualAmount = double.Parse(value)
            };
            return true;
        }
    }
}
