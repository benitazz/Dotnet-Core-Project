using MedicalBilingMicroservice.Core.Models.Entities.Users;
using MedicalBilingMicroservice.Persistence.EntityConfigurations.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedicalBilingMicroservice.Persistence {
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string> {
        public ApplicationDbContext (DbContextOptions options) : base (options) {

        }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            base.OnModelCreating (modelBuilder);
            modelBuilder.ApplyConfiguration (new ApplicationRoleConfiguration ());
            modelBuilder.ApplyConfiguration (new ApplicationUserConfiguration ());
        }
    }
}