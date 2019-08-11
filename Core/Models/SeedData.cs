using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MedicalBilingMicroservice.Core.Models.Entities.Users;
using MedicalBilingMicroservice.Persistence;
using Microsoft.AspNetCore.Identity;

namespace MedicalBilingMicroservic.Core.Models
{
    public class seedData
    {
        public static async Task Initialize(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            //context.Database.EnsureCreated();

            string adminRole = "Admin";
            string managerRole = "Manager";
            string memberRole = "Member";
            string password = "P@$$w0rd";

            string[] roleNames = { adminRole, managerRole, memberRole };
            Dictionary<string, string> roles = new Dictionary<string, string>();
            roles.Add(adminRole, "This is the administrator role");
            roles.Add(managerRole, "This is the manager role");
            roles.Add(memberRole, "This is the member role");

            IdentityResult roleResult;

            foreach (var roleName in roles)
            {
                var roleExist = await roleManager.RoleExistsAsync(roleName.Key);
                if (!roleExist)
                {
                    var role = new ApplicationRole(roleName.Key,
                              roleName.Value,
                              DateTime.Now);
                    role.CreatedBy = adminRole;
                    role.UpdatedBy = adminRole;

                    roleResult = await roleManager.CreateAsync(role);
                }
            }

            if (await userManager.FindByNameAsync("admin") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "admin@admin.admin",
                    Email = "admin@admin.admin",
                    FirstName = "Ben",
                    LastName = "Baloyi",
                    PhoneNumber = "0781881287",
                    UpdatedBy = adminRole
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, adminRole);
                }
            }
        }
    }
}