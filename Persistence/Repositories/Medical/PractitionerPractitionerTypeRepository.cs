using MedicalEngineMicroService.Core.Models.Entities.Medical;
using MedicalEngineMicroService.Core.Repositories.Medical;
using Microsoft.EntityFrameworkCore;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Medical {
    public class PractitionerPractitionerTypeRepository : Repository<PractitionerPractitionerType>, IPractitionerPractitionerTypeRepository
    {
        public PractitionerPractitionerTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}