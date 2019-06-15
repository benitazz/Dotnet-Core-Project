using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using MedicalBilingMicroservice.Core.Repositories.Tariffs;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories.Tariffs {
    public class MedicalItemTypeRepository : Repository<MedicalItemType>, IMedicalItemTypeRepository {
        public MedicalItemTypeRepository (ApplicationDbContext dbContext) : base (dbContext) {

        }
    }
}