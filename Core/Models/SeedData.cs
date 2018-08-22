using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MedicalBilingMicroservice.Core.Models.Entities.Users;
using MedicalBilingMicroservice.Persistence;
using Microsoft.AspNetCore.Identity;

namespace MedicalBilingMicroservic.Core.Models {
    public class seedData {
        public static async Task Initialize (ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager) {
            context.Database.EnsureCreated ();

            // String adminId1 = "";
             // String adminId2 = "";
            string password = "P@$$w0rd";

            /* string role1 = "Admin";
             string desc1 = "This is the administrator role";

             string role2 = "Member";
             string desc2 = "This is the members role";

             string password = "P@$$w0rd";

             if (await roleManager.FindByNameAsync(role1) == null)
             {
                 await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
             }
             if (await roleManager.FindByNameAsync(role2) == null)
             {
                 await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
             }*/

            string[] roleNames = { "Admin", "Manager", "Member" };
            Dictionary<string, string> roles = new Dictionary<string, string> ();
            roles.Add ("Admin", "This is the administrator role");
            roles.Add ("Manager", "This is the manager role");
            roles.Add ("Member", "This is the member role");


            IdentityResult roleResult;

            foreach (var roleName in roles) {
                var roleExist = await roleManager.RoleExistsAsync (roleName.Key);
                if (!roleExist) {
                   var role =  new ApplicationRole (roleName.Key,
                             roleName.Value,
                             DateTime.Now);
                    role.CreatedBy = "Admin";
                    role.UpdatedBy = "Admin";

                    roleResult = await roleManager.CreateAsync (role);
                }
            }

            if (await userManager.FindByNameAsync ("admin") == null) {
                var user = new ApplicationUser {
                UserName = "admin@admin.admin",
                Email = "admin@admin.admin",
                FirstName = "Ben",
                LastName = "Baloyi",
                PhoneNumber = "0781881287",
                UpdatedBy = "Admin"
                };

                var result = await userManager.CreateAsync (user);
                if (result.Succeeded) {
                    await userManager.AddPasswordAsync (user, password);
                    await userManager.AddToRoleAsync (user, "Admin");
                }
                // adminId1 = user.Id;
            }

            /*if (await userManager.FindByNameAsync ("b") == null) {
                var user = new ApplicationUser {
                UserName = "b@b.b",
                Email = "b@b.b",
                FirstName = "Bob",
                LastName = "Barker",
                PhoneNumber = "7788951456"
                };

                var result = await userManager.CreateAsync (user);
                if (result.Succeeded) {
                    await userManager.AddPasswordAsync (user, password);
                    await userManager.AddToRoleAsync (user, role1);
                }
                adminId2 = user.Id;
            }

            if (await userManager.FindByNameAsync ("m") == null) {
                var user = new ApplicationUser {
                UserName = "m@m.m",
                Email = "m@m.m",
                FirstName = "Mike",
                LastName = "Myers",
                PhoneNumber = "6572136821"
                };

                var result = await userManager.CreateAsync (user);
                if (result.Succeeded) {
                    await userManager.AddPasswordAsync (user, password);
                    await userManager.AddToRoleAsync (user, role2);
                }
            }

            if (await userManager.FindByNameAsync ("d") == null) {
                var user = new ApplicationUser {
                UserName = "d@d.d",
                Email = "d@d.d",
                FirstName = "Donald",
                LastName = "Duck",
                PhoneNumber = "6041234567"
                };

                var result = await userManager.CreateAsync (user);
                if (result.Succeeded) {
                    await userManager.AddPasswordAsync (user, password);
                    await userManager.AddToRoleAsync (user, role2);
                }
            }*/
        }
    }
}