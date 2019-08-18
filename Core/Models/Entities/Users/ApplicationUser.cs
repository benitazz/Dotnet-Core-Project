using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Identity;

namespace MedicalEngineMicroService.Core.Models.Entities.Users
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PracticeNumber { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public ICollection<ApplicationUserRole> UserRoles { get; set; }

        public ApplicationUser()
        {
            this.UserRoles = new Collection<ApplicationUserRole>();
        }
    }
}