using MedicalBilingBackEnd.Core.Models.Entities;

namespace MedicalBilingMicroservice.Core.Models.Entities.Tariffs {
    public class MedicalItemCodeDescription : EntityBase {
        public int Id { get; set; }
        public string Description { get; set; }
        public int MedicalItemCodeId { get; set; }
        public MedicalItemCode MedicalItemCode { get; set; }
    }
}