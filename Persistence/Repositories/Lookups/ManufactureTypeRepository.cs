using MedicalEngineMicroService.Core.Models.Entities.Lookups;
using MedicalEngineMicroService.Core.Repositories.Lookups;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Lookups
{
    public class ManufactureTypeRepository : Repository<ManufactureType>, IManufactureTypeRepository
    {
        public ManufactureTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}