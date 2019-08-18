using Microsoft.AspNetCore.Identity;

namespace MedicalEngineMicroService.Core.Models.Entities.Users
{
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationRole Role { get; set; }
    }
}