namespace MedicalBilingBackEnd.Resources.ApiToDomainResource.Tariffs
{
    public class TariffResource
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int TariffTypeId { get; set; }
        //public TariffType TariffType { get; set; }
        // public virtual ICollection<TariffUnitCost> TariffUnitCostS { get; set; }
        public TariffResource()
        {
            // this.TariffUnitCostS = new HashSet<TariffUnitCost>();
        }
    }
}