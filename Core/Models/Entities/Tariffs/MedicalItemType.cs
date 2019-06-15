using MedicalBilingBackEnd.Core.Models.Entities;

namespace MedicalBilingMicroservice.Core.Models.Entities.Tariffs {
    public class MedicalItemType : EntityBase 
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}