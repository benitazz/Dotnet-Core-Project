using MedicalEngineMicroService.Core.Repositories.Medical;
using Microsoft.EntityFrameworkCore;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Medical {
    public class PublicationRepository : Repository<Publication>, IPublicationRepository {
        public PublicationRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}