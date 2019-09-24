using MedicalEngineMicroService.Core.Models.Entities.Medical;
using MedicalEngineMicroService.Core.Repositories.Medical;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Medical {
    public class PractitionerTypeRepository : Repository<PractitionerType>, IPractitionerTypeRepository {
        public PractitionerTypeRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}