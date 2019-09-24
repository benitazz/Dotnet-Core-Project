using MedicalEngineMicroService.Core.Models.Entities.Medical;
using MedicalEngineMicroService.Core.Repositories.Medical;

namespace MedicalEngineMicroService.Persistence.Repositories.Medical {
    public class MedicalItemPublicationPeriodRepository : 
        Repository<MedicalItemPublicationPeriod>, IMedicalItemPublicationPeriodRepository {
        public MedicalItemPublicationPeriodRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}