using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using MedicalEngineMicroService.Core.Repositories.Tariffs;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Tariffs {
    public class NappiCodeRepository : Repository<NappiCode>, INappiCodeRepository {
        public NappiCodeRepository (ApplicationDbContext dbContext) : base (dbContext) 
        {

        }
    }
}