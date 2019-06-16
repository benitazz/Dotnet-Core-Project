using MedicalBilingBackEnd.Core.Models.Entities.Lookups;

namespace MedicalBilingMicroservice.Core.Models.Entities.Tariffs {
    public class Practitioner : Lookup {
        public string PracticeCode { get; set; }
        public double MaxTreatmentDays { get; set; }
        public string NRPLPracticeCode { get; set; }
        public bool IsMedReportRequired { get; set; }
        public int PractitionerGroupTypeId { get; set; }
        public PractitionerGroupType PractitionerGroupType { get; set; }
    }
}