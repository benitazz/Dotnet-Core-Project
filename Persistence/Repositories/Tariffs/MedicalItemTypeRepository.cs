using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using MedicalEngineMicroService.Core.Repositories.Tariffs;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Tariffs {
    public class MedicalItemTypeRepository : Repository<MedicalItemType>, IMedicalItemTypeRepository {
        public MedicalItemTypeRepository (ApplicationDbContext dbContext) : base (dbContext) {

        }
    }
}