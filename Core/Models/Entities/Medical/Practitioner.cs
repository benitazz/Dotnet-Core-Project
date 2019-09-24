using MedicalEngineMicroService.Core.Models.Entities.Lookups;

namespace MedicalEngineMicroService.Core.Models.Entities.Medical {
    public class Practitioner : LookupBase {
        public string PracticeCode { get; set; }
        public double MaxTreatmentDays { get; set; }
        public string NRPLPracticeCode { get; set; }
        public bool? IsMedReportRequired { get; set; }
        public int PractitionerGroupTypeId { get; set; }
        public PractitionerGroupType PractitionerGroupType { get; set; }
    }
}