using MedicalEngineMicroService.Core.Models.Entities.Medical;
using MedicalEngineMicroService.Core.Repositories.Medical;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Medical
{
    public class MedicalItemDescriptionRepository : Repository<MedicalItemPublication>, IMedicalItemPublicationRepository {
        public MedicalItemDescriptionRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}