using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using MedicalEngineMicroService.Core.Repositories.Tariffs;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Tariffs {
    public class MedicalItemRepository : Repository<MedicalItem>, IMedicalItemRepository
    {
        public MedicalItemRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}