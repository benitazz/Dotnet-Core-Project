using AutoMapper;
using MedicalEngineMicroService.Core.Models.Entities.Lookups;
using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using MedicalEngineMicroService.Resources.ApiToDomainResource.Lookups;
using MedicalEngineMicroService.Resources.DomainToApiResource.Lookups;
using MedicalEngineMicroService.Core.Models.Entities.Users;
using MedicalEngineMicroService.Resources.ApiToDomainResource;

namespace MedicalEngineMicroService.Mapping {
    public class ResourceToEntityMapping : Profile {
        public ResourceToEntityMapping () {
            CreateMap<RegistrationResource, ApplicationUser> ()
                .ForMember (entity => entity.UserName,
                    map => map.MapFrom (resource => resource.Email));
            
             CreateMap<SaveLookupResource, TariffType> ();
        }
    }
}