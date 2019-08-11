using MedicalBilingMicroservice.Core.Models.Entities.Lookups;
using MedicalBilingMicroservice.Core.Repositories.Lookups;
using Microsoft.EntityFrameworkCore;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories.Lookups
{
    public class DosageTypeRepository : Repository<DosageType>, IDosageTypeRepository
    {
        public DosageTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}