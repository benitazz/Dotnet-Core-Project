using MedicalBilingBackEnd.Core.Models.Entities;

namespace MedicalBilingMicroservice.Core.Models.Entities.Tariffs {
    public class MedicalItemCodePublication : EntityBase {
        public int Id { get; set; }
        public int MedicalItemCodeDescriptionId { get; set; }
        public MedicalItemCodeDescription MedicalItemCodeDescription { get; set; }
        public int PublicationId { get; set; }
        public Publication Publication { get; set; }
        public int SectionTypeId { get; set; }
        public SectionType SectionType { get; set; }
    }
}