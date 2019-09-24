using MedicalEngineMicroService.Core.Models.Entities.Medical;
using MedicalEngineMicroService.Core.Repositories.Medical;

namespace MedicalEngineMicroService.Persistence.Repositories.Medical {
    public class SectionRepository : Repository<Section>, ISectionRepository
    {
        public SectionRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}