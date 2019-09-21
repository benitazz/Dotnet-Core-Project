using MedicalBilingMicroservice.Core.Models.Entities.Lookups;
using MedicalEngineMicroService.Core.Models.Entities;

namespace MedicalEngineMicroService.Core.Models.Entities.Tariffs {
    public class MedicalItemPublication : LookupDescriptionBase {
        public int MedicalItemId { get; set; }
        public MedicalItem MedicalItem { get; set; }
        public int PublicationId { get; set; }
        public Publication Publication { get; set; }
        // public string Description { get; set; }
        public double Quantity { get; set; }

    }
}