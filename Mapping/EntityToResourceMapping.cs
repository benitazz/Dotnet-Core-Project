using System.Linq;
using AutoMapper;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using MedicalBilingBackEnd.Resources.DomainToApiResource.Lookups;
using MedicalBilingMicroservice.Core.Models.Entities.Users;
using MedicalBilingMicroservice.Resources.DomainToApiResource;

namespace MedicalBilingMicroservice.Mapping
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

            CreateMap<Vat, VatTypeResource>();

            /*CreateMap<ApplicationUser, ApplicationUserResource> ()
                .ForMember (userResource => userResource.Roles,
                    opt => opt.MapFrom (user => user.UserRoles
                        .Select (userRole =>
                            Mapper.Map<ApplicationRole, ApplicationRoleResource> (userRole.Role)
                        )));*/

        }
    }
}