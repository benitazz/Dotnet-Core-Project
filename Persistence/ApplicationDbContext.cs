
using MedicalBilingMicroservice.Core.Models.Entities.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedicalBilingMicroservice.Persistence {
    public class ApplicationDbContext : IdentityDbContext<AppUser> {
        public ApplicationDbContext (DbContextOptions options) : base (options) {

        }
    }
}