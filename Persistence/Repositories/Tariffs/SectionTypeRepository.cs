using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using MedicalBilingMicroservice.Core.Repositories.Tariffs;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories.Tariffs {
    public class SectionTypeRepository : Repository<SectionType>, ISectionTypeRepository
    {
        public SectionTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}