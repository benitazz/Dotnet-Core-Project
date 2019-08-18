using MedicalEngineMicroService.Core.Models.Entities.Lookups;
using MedicalEngineMicroService.Core.Repositories.Lookups;
using Microsoft.EntityFrameworkCore;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Lookups
{
    public class DosageTypeRepository : Repository<DosageType>, IDosageTypeRepository
    {
        public DosageTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}