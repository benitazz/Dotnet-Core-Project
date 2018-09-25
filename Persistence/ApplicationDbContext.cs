using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingBackEnd.Core.Models.Entities.Lookups;
using MedicalBilingMicroservice.Core.Models.Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MedicalBilingMicroservice.Persistence
{
    public class ApplicationDbContext :
        IdentityDbContext<ApplicationUser,
        ApplicationRole,
        string,
        IdentityUserClaim<string>,
        ApplicationUserRole,
        IdentityUserLogin<string>,
        IdentityRoleClaim<string>,
        IdentityUserToken<string>>
    {

        public DbSet<FileStatus> FileStatuses { get; set; }
        public DbSet<InvoiceStatus> InvoiceStatuses { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();  
        }
    }
}