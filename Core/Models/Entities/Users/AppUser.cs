using Microsoft.AspNetCore.Identity;

namespace MedicalBilingMicroservice.Core.Models.Entities.Users {
    public class AppUser: IdentityUser {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}