using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using MedicalBilingMicroservice.Core.Repositories.Tariffs;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories.Tariffs
{
    public class MedicalItemCodeDescriptionRepository : Repository<MedicalItemCodeDescription>, IMedicalItemCodeDescriptionRepository {
        public MedicalItemCodeDescriptionRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}