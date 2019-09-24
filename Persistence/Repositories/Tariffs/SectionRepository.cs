using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using MedicalEngineMicroService.Core.Repositories.Tariffs;

namespace MedicalEngineMicroService.Persistence.Repositories.Tariffs {
    public class SectionRepository : Repository<Section>, ISectionRepository
    {
        public SectionRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}