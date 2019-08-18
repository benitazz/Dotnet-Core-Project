using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MedicalEngineMicroService.Resources.DomainToApiResource {
    public class ApplicationUserResource {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PracticeNo { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public ICollection<ApplicationRoleResource> Roles { get; set; }

        public ApplicationUserResource () {
            this.Roles = new Collection<ApplicationRoleResource> ();
        }
    }
}