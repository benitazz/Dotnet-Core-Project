using System.Linq;
using AutoMapper;
using MedicalEngineMicroService.Core.Models.Entities.Lookups;
using MedicalEngineMicroService.Resources.DomainToApiResource.Lookups;
using MedicalEngineMicroService.Core.Models.Entities.Users;
using MedicalEngineMicroService.Resources.DomainToApiResource;

namespace MedicalEngineMicroService.Mapping
{
    public class EntityToResourceMapping : Profile
    {
        public EntityToResourceMapping()
        {
            CreateMap<ApplicationRole, ApplicationRoleResource>();
            CreateMap<ApplicationUserRole, ApplicationUserRoleResource>();
            CreateMap<ApplicationUser, ApplicationUserResource>()
                .ForMember(userResource => userResource.Roles,
                    opt => opt.MapFrom(user => user.UserRoles
                       .Select(userRole =>
                          new ApplicationRoleResource
                           {
                               Id = (userRole != null && userRole.Role != null) ? userRole.Role.Id : null,
                               Name = (userRole != null && userRole.Role != null) ? userRole.Role.Name : null,
                               Description = (userRole != null && userRole.Role != null) ? userRole.Role.Description : null
                           }
                       )));

            CreateMap<VatType, VatTypeResource>();

            /*CreateMap<ApplicationUser, ApplicationUserResource> ()
                .ForMember (userResource => userResource.Roles,
                    opt => opt.MapFrom (user => user.UserRoles
                        .Select (userRole =>
                            Mapper.Map<ApplicationRole, ApplicationRoleResource> (userRole.Role)
                        )));*/

        }
    }
}