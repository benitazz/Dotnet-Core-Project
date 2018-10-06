using AutoMapper;
using MedicalBilingBackEnd.Core.Models.Entities.Lookups;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using MedicalBilingBackEnd.Resources.DomainToApiResource.Lookups;
using MedicalBilingMicroservice.Core.Models.Entities.Users;
using MedicalBilingMicroservice.Resources.ApiToDomainResource;

namespace MedicalBilingMicroservice.Mapping {
    public class ResourceToEntityMapping : Profile {
        public ResourceToEntityMapping () {
            CreateMap<RegistrationResource, ApplicationUser> ()
                .ForMember (entity => entity.UserName,
                    map => map.MapFrom (resource => resource.Email));
            
             CreateMap<LookupResource, Lookup> ();
        }
    }
}