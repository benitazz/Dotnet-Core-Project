using System;
using MedicalEngineMicroService.Core.Models.Entities;

namespace MedicalEngineMicroService.Core.Models.Entities.Medical {
    public class MedicalItemPublicationPeriod: EntityBase {
        public int MedicalItemPublicationId { get; set; }
        public MedicalItemPublication MedicalItemPublication { get; set; }
        public DateTime ValiFrom { get; set; }
        public DateTime ValidTo { get; set; }

    }
}