using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using MedicalEngineMicroService.Core.Repositories.Tariffs;
using Microsoft.EntityFrameworkCore;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Tariffs {
    public class PractitionerGroupTypeRepository : Repository<PractitionerGroupType>, IPractitionerGroupTypeRepository
    {
        public PractitionerGroupTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}