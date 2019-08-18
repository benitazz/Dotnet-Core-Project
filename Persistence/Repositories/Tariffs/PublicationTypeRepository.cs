using MedicalEngineMicroService.Core.Repositories.Tariffs;
using Microsoft.EntityFrameworkCore;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Tariffs {
    public class PublicationTypeRepository : Repository<PublicationType>, IPublicationTypeRepository {
        public PublicationTypeRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}