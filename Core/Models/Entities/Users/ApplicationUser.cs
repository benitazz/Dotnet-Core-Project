using System;
using Microsoft.AspNetCore.Identity;

namespace MedicalBilingMicroservice.Core.Models.Entities.Users {
    public class ApplicationUser : IdentityUser {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PracticeNumber { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }
    }
}