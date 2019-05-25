using MedicalBilingMicroservice.Core.Repositories.Tariffs;
using Microsoft.EntityFrameworkCore;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories.Tariffs {
    public class PublicationRepository : Repository<Publication>, IPublicationRepository {
        public PublicationRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}