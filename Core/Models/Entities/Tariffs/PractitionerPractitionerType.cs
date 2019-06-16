using MedicalBilingBackEnd.Core.Models.Entities;

namespace MedicalBilingMicroservice.Core.Models.Entities.Tariffs {
    public class PractitionerPractitionerType : EntityBase {
        public int Id { get; set; }
        public int PractitionerId { get; set; }
        public Practitioner Practitioner { get; set; }
        public int PractionerTypeId { get; set; }
        public PractitionerType PractitionerType { get; set; }

    }
}