using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using MedicalBilingMicroservice.Core.Repositories.Tariffs;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories.Tariffs
{
    public class MedicalItemDescriptionRepository : Repository<MedicalItemPublication>, IMedicalItemPublicationRepository {
        public MedicalItemDescriptionRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}