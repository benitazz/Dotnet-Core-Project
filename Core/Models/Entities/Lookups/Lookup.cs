using System.ComponentModel.DataAnnotations;

namespace MedicalBilingBackEnd.Core.Models.Entities.Lookups
{
    public abstract class Lookup: EntityBase
    {
        // [Key]
        public int Id { get; set; }

        /*[Required]
        [MinLength(5)]
        [MaxLength(255)]*/
        public string Name { get; set; }

        // [MaxLength(255)]
        public string Description { get; set; }
    }
}