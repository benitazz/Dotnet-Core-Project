using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using MedicalEngineMicroService.Core.Repositories.Tariffs;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Tariffs
{
    public class MedicalItemDescriptionRepository : Repository<MedicalItemPublication>, IMedicalItemPublicationRepository {
        public MedicalItemDescriptionRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}