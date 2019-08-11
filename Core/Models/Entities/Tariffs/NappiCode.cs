using MedicalBilingBackEnd.Core.Models.Entities;
using MedicalBilingMicroservice.Core.Models.Entities.Lookups;

namespace MedicalBilingMicroservice.Core.Models.Entities.Tariffs {
    public class NappiCode : EntityBase {
        public string Code { get; set; }
        public int? Schedule { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int DosageTypeId { get; set; }
        public DosageType DosageType { get; set; }
    }
}