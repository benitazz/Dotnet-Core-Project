using MedicalEngineMicroService.Core.Models.Entities;

namespace MedicalBilingMicroservice.Core.Models.Entities.Lookups {
    public abstract class LookupDescriptionBase : EntityBase {
        public string Description { get; set; }
        public string NormalizedDescription { get; set; }
    }
}