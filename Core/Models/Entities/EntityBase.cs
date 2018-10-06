using System;

namespace MedicalBilingBackEnd.Core.Models.Entities
{
    public abstract class EntityBase
    {
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }
    }
}