using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using MedicalBilingMicroservice.Core.Repositories.Tariffs;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories.Tariffs {
    public class NappiCodeRepository : Repository<NappiCode>, INappiCodeRepository {
        public NappiCodeRepository (ApplicationDbContext dbContext) : base (dbContext) 
        {

        }
    }
}