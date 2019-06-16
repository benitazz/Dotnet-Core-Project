using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using MedicalBilingMicroservice.Core.Repositories.Tariffs;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories.Tariffs {
    public class PractitionerTypeRepository : Repository<PractitionerType>, IPractitionerTypeRepository {
        public PractitionerTypeRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}