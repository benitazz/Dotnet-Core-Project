using MedicalBilingBackEnd.Core.Models.Entities;

namespace MedicalBilingMicroservice.Core.Models.Entities.Tariffs {
    public class MedicalItemPublication : EntityBase {
        public int MedicalItemDescriptionId { get; set; }
        public MedicalItemDescription MedicalItemDescription { get; set; }
        public int PublicationTypeId { get; set; }
        public PublicationType PublicationType { get; set; }
        public int SectionTypeId { get; set; }
        public SectionType SectionType { get; set; }
    }
}