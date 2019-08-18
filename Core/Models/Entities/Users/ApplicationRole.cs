using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace MedicalEngineMicroService.Core.Models.Entities.Users
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }

        public ApplicationRole(string roleName) : base(roleName) { }

        public ApplicationRole(string roleName, string description,
            DateTime createdDate)
            : base(roleName)
        {
            base.Name = roleName;

            this.Description = description;
            this.CreatedDate = createdDate;
        }

        public string Description { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public ICollection<ApplicationUserRole> UserRoles { get; set; }
    }
}