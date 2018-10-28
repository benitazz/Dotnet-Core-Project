using MedicalBilingBackEnd.Common.Helpers;

namespace MedicalBilingBackEnd.Resources.ApiToDomainResource.Tariffs
{
    public class SaveTariffResource
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int TariffTypeId { get; set; }
        //public TariffType TariffType { get; set; }
        // public virtual ICollection<TariffUnitCost> TariffUnitCostS { get; set; }
        public SaveTariffResource(UserResolverService userResolverService)
        {
            var user = userResolverService.GetUser();

            // this.TariffUnitCostS = new HashSet<TariffUnitCost>();
        }
    }
}