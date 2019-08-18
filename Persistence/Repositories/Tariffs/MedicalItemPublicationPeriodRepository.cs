using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using MedicalEngineMicroService.Core.Repositories.Tariffs;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Tariffs {
    public class MedicalItemPublicationPeriodRepository : 
        Repository<MedicalItemPublicationPeriod>, IMedicalItemPublicationPeriodRepository {
        public MedicalItemPublicationPeriodRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}