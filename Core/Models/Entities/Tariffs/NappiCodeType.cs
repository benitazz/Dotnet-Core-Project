using MedicalBilingBackEnd.Core.Models.Entities;

namespace MedicalBilingMicroservice.Core.Models.Entities.Tariffs {
    public class NappiCodeType : EntityBase {
        public string NappiCode { get; set; }
        public string ProductName { get; set; }
        public int ProductStrength { get; set; }
        public int DosageFrom { get; set; }
        public int ProductPackSize { get; set; }
        public string ManufacturerCode { get; set; }
        public int Schedule { get; set; }

    }
}