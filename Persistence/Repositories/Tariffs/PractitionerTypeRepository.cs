using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using MedicalEngineMicroService.Core.Repositories.Tariffs;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Tariffs {
    public class PractitionerTypeRepository : Repository<PractitionerType>, IPractitionerTypeRepository {
        public PractitionerTypeRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}