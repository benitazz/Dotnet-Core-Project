using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using MedicalBilingMicroservice.Core.Repositories.Tariffs;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories.Tariffs
{
    public class MedicalItemDescriptionRepository : Repository<MedicalItemDescription>, IMedicalItemDescriptionRepository {
        public MedicalItemDescriptionRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}