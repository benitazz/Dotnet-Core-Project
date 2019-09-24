using MedicalEngineMicroService.Core.Models.Entities.Medical;
using MedicalEngineMicroService.Core.Repositories.Medical;
using Microsoft.EntityFrameworkCore;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Medical {
    public class PractitionerGroupTypeRepository : Repository<PractitionerGroupType>, IPractitionerGroupTypeRepository
    {
        public PractitionerGroupTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}