using System;

namespace MedicalEngineMicroService.Core.Models.Entities.Patients
{
    public class Patient
    {
        public int Id { get; set; }
        public string Initials { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string PatientReferenceNumber { get; set; }
        public DateTime BirthDate { get; set; }
    
    }
}