using MedicalBilingBackEnd.Core.Models.Entities;

namespace MedicalBilingMicroservice.Core.Models.Entities.Tariffs {
    public class NappiCodeType : EntityBase {
        public string NappiCode { get; set; }
        public string DosageFrom { get; set; }
        public int? Schedule { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}