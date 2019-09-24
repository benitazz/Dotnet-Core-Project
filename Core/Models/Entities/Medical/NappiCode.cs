using MedicalEngineMicroService.Core.Models.Entities;
using MedicalEngineMicroService.Core.Models.Entities.Lookups;

namespace MedicalEngineMicroService.Core.Models.Entities.Medical {
    public class NappiCode : EntityBase {
        public string Code { get; set; }
        public int? Schedule { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int DosageTypeId { get; set; }
        public DosageType DosageType { get; set; }
    }
}