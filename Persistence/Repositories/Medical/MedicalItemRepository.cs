using MedicalEngineMicroService.Core.Models.Entities.Medical;
using MedicalEngineMicroService.Core.Repositories.Medical;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Medical {
    public class MedicalItemRepository : Repository<MedicalItem>, IMedicalItemRepository
    {
        public MedicalItemRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}