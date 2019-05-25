using MedicalBilingBackEnd.Core.Models.Entities;

namespace MedicalBilingMicroservice.Core.Models.Entities.Doctors
{
    public class Practioner: EntityBase
    {
        public int Id { get; set; }
        public string PracticeNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsHospital { get; set; }
        public int PublicationId { get; set; }
        public Publication Publication { get; set; }
     }
}