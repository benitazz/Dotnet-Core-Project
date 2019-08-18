using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using MedicalEngineMicroService.Core.Repositories.Tariffs;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Tariffs {
    public class SectionTypeRepository : Repository<SectionType>, ISectionTypeRepository
    {
        public SectionTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}