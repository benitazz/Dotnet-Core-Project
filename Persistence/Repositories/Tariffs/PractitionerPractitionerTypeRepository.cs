using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using MedicalEngineMicroService.Core.Repositories.Tariffs;
using Microsoft.EntityFrameworkCore;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Tariffs {
    public class PractitionerPractitionerTypeRepository : Repository<PractitionerPractitionerType>, IPractitionerPractitionerTypeRepository
    {
        public PractitionerPractitionerTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}