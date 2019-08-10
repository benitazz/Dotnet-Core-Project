using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using MedicalBilingMicroservice.Core.Repositories.Tariffs;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories.Tariffs {
    public class NappiCodeTypeRepository : Repository<NappiCodeType>, INappiCodeTypeRepository {
        public NappiCodeTypeRepository (ApplicationDbContext dbContext) : base (dbContext) 
        {

        }
    }
}