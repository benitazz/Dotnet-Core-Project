using MedicalBilingMicroservice.Core.Models.Entities.Lookups;
using MedicalBilingMicroservice.Core.Repositories.Lookups;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories.Lookups
{
    public class ManufactureTypeRepository : Repository<ManufactureType>, IManufactureTypeRepository
    {
        public ManufactureTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}