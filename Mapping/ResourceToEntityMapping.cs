using AutoMapper;
using MedicalBilingMicroservice.Core.Models.Entities.Users;
using MedicalBilingMicroservice.Resources.ApiToDomainResource;

namespace MedicalBilingMicroservice.Mapping {
    public class ResourceToEntityMapping : Profile {
        public ResourceToEntityMapping () {
            CreateMap<RegistrationResource, AppUser> ()
                .ForMember (entity => entity.UserName,
                    map => map.MapFrom (resource => resource.Email));
        }

    }
}