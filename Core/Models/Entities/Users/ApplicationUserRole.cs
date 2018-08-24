using Microsoft.AspNetCore.Identity;

namespace MedicalBilingMicroservice.Core.Models.Entities.Users
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationRole Role { get; set; }
    }
}