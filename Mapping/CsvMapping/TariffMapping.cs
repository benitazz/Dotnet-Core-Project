using System;
using System.Collections.Generic;
using CsvHelper.Configuration;
using MedicalBilingBackEnd.Core;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using MedicalBilingBackEnd.Resources.ApiToDomainResource.FileUploads;
using MedicalBilingBackEnd.Common.Enums;
using CsvHelper;

namespace MedicalBilingBackEnd.Mapping.CsvMapping
{
    public class TariffMapping : ClassMap<Tariff>
    {
        public
        TariffMapping(TariffFileResource tariffFileResource)
        {
            /*Map(m => m.Code);
            Map(m => m.TariffTypeId).ConvertUsing(row => tariffFileResource.TariffTypeId);*/
            Map(m => m.CreatedDate).ConvertUsing(row => DateTime.Now);
            Map(m => m.UpdatedDate).ConvertUsing(row => DateTime.Now);
            Map(m => m.CreatedBy).ConvertUsing((IReaderRow row) => "Administrator");
            Map(m => m.UpdatedBy).ConvertUsing((IReaderRow row) => "Administrator");
           /*Map(m => m.TariffUnitCostS).ConvertUsing(row =>
         {
             var list = new List<TariffUnitCost>();
             list.Add(new TariffUnitCost
             {
                 // VatId = tariffFileResource.VatId,
                 ValidFrom = tariffFileResource.ValidFrom,
                 ValidTo = tariffFileResource.ValidTo,
                 ActualAmount = GetActualAmount(row.GetField(1), tariffFileResource.VatId),
                 //VatAmount = double.Parse(row.GetField(1)),
                 CreatedDate = DateTime.Now,
                 UpdatedDate = DateTime.Now,
                 CreatedBy = "Administrator",
                 UpdatedBy = "Administrator"
             });
             return list;
         });*/
            /*/MapProperty(0, x => x.Code);
            MapProperty(1, x => x.TariffTypeId);
            MapProperty(2, x => x.TariffUnitCostS);*/
        }

        private double GetActualAmount(string vatAmount, int vatId)
        {
            var amount = double.Parse(vatAmount);
            var fourteenPercent = 0.14;
            var fifteenPercent = 0.15;
            return vatId == (int)Common.Enums.VatType.FifteenPercentage
                    ? (amount - amount * fifteenPercent)
                    : (amount - amount * fourteenPercent);
        }
    }
}

