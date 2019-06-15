using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using MedicalBilingMicroservice.Core.Repositories.Tariffs;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories.Tariffs {
    public class MedicalItemCodePublicationRepository : Repository<MedicalItemCodePublication>, IMedicalItemCodePublicationRepository {
        public MedicalItemCodePublicationRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}