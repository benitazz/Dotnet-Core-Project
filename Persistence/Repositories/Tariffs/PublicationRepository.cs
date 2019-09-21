using MedicalEngineMicroService.Core.Repositories.Tariffs;
using Microsoft.EntityFrameworkCore;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Tariffs {
    public class PublicationRepository : Repository<Publication>, IPublicationRepository {
        public PublicationRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}