using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using MedicalBilingMicroservice.Core.Repositories.Tariffs;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories.Tariffs {
    public class MedicalItemPublicationRepository : Repository<MedicalItemPublication>, IMedicalItemPublicationRepository {
        public MedicalItemPublicationRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}