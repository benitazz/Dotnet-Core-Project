using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using MedicalBilingMicroservice.Core.Repositories.Tariffs;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories.Tariffs {
    public class MedicalItemPublicationPeriodRepository : 
        Repository<MedicalItemPublicationPeriod>, IMedicalItemPublicationPeriodRepository {
        public MedicalItemPublicationPeriodRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}