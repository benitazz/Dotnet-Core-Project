using MedicalEngineMicroService.Core.Models.Entities.Medical;
using MedicalEngineMicroService.Core.Repositories.Medical;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Medical {
    public class NappiCodeRepository : Repository<NappiCode>, INappiCodeRepository {
        public NappiCodeRepository (ApplicationDbContext dbContext) : base (dbContext) 
        {

        }
    }
}