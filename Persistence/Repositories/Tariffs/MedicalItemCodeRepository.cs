using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using MedicalBilingMicroservice.Core.Repositories.Tariffs;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories.Tariffs {
    public class MedicalItemCodeRepository : Repository<MedicalItemCode>, IMedicalItemCodeRepository
    {
        public MedicalItemCodeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}