using MedicalEngineMicroService.Core.Models.Entities;

namespace MedicalEngineMicroService.Core.Models.Entities.Tariffs {
    public class MedicalItemPublication : EntityBase {
        public int MedicalItemId { get; set; }
        public MedicalItem MedicalItem { get; set; }
        public int PublicationTypeId { get; set; }
        public PublicationType PublicationType { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }

    }
}