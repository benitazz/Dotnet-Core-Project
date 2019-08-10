using MedicalBilingBackEnd.Core.Models.Entities;

namespace MedicalBilingMicroservice.Core.Models.Entities.Tariffs {
    public class MedicalItemPublication : EntityBase {
        public int MedicalItemId { get; set; }
        public MedicalItem MedicalItem { get; set; }
        public int PublicationTypeId { get; set; }
        public PublicationType PublicationType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }

    }
}