using MedicalBilingBackEnd.Core.Models.Entities;

namespace MedicalBilingMicroservice.Core.Models.Entities.Tariffs {
    public class MedicalItemDescription : EntityBase {
        public int Id { get; set; }
        public string Description { get; set; }
        public int MedicalItemId { get; set; }
        public MedicalItem MedicalItem { get; set; }
    }
}