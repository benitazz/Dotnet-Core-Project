using System;
using MedicalBilingBackEnd.Core.Models.Entities;

namespace MedicalBilingMicroservice.Core.Models.Entities.Tariffs {
    public class MedicalItemPublicationPeriod: EntityBase {
        public int MedicalItemPublicationId { get; set; }
        public MedicalItemPublication MedicalItemPublication { get; set; }
        public DateTime ValiFrom { get; set; }
        public DateTime ValidTo { get; set; }

    }
}