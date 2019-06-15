using System;
using MedicalBilingBackEnd.Core.Models.Entities;

namespace MedicalBilingMicroservice.Core.Models.Entities.Tariffs {
    public class MedicalItemCode : EntityBase {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}