using System.ComponentModel.DataAnnotations;

namespace MedicalBilingBackEnd.Core.Models.Entities.Lookups
{
    public abstract class Lookup: EntityBase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string NormalizedName { get; set; }

         public string NormalizedDescription { get; set; }
    }
}