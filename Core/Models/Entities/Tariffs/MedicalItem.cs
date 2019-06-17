using System;
using MedicalBilingBackEnd.Core.Models.Entities;

namespace MedicalBilingMicroservice.Core.Models.Entities.Tariffs {
    public class MedicalItem : EntityBase {
        public string Code { get; set; }
        public string Name { get; set; }
        public int MedicalItemTypeId { get; set; }
        public MedicalItemType MedicalItemType { get; set; }
    }
}