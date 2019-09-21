namespace MedicalEngineMicroService.Core.Models.Entities.Tariffs
{
    public class MedicalItem : EntityBase {
        public string Code { get; set; }
        public int MedicalItemTypeId { get; set; }
        public MedicalItemType MedicalItemType { get; set; }
        public int? NappiCodeId { get; set; }
        public NappiCode NappiCode { get; set; }

    }
}