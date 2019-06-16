using MedicalBilingMicroservice.Core.Repositories.Tariffs;
using Microsoft.EntityFrameworkCore;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories.Tariffs {
    public class PublicationTypeRepository : Repository<PublicationType>, IPublicationTypeRepository {
        public PublicationTypeRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}