using MedicalEngineMicroService.Core.Models.Entities.Medical;
using MedicalEngineMicroService.Core.Repositories.Medical;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Medical {
    public class MedicalItemTypeRepository : Repository<MedicalItemType>, IMedicalItemTypeRepository {
        public MedicalItemTypeRepository (ApplicationDbContext dbContext) : base (dbContext) {

        }
    }
}