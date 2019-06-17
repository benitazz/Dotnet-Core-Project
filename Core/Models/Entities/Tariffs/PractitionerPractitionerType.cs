using MedicalBilingBackEnd.Core.Models.Entities;

namespace MedicalBilingMicroservice.Core.Models.Entities.Tariffs {
    public class PractitionerPractitionerType : EntityBase {
        public int PractitionerId { get; set; }
        public Practitioner Practitioner { get; set; }
        public int PractitionerTypeId { get; set; }
        public PractitionerType PractitionerType { get; set; }

    }
}