using System;
using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using TinyCsvParser.TypeConverter;

namespace MedicalEngineMicroService.Mapping.CsvMapping
{
    public class TariffMappingConverter : ITypeConverter<TariffBaseUnitCost>
    {
        public Type TargetType => typeof(TariffBaseUnitCost);

        public bool TryConvert(string value, out TariffBaseUnitCost result)
        {
            result = new TariffBaseUnitCost
            {
                UnitPrice = double.Parse(value)
            };
            return true;
        }
    }
}
