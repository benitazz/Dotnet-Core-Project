using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using MedicalBilingMicroservice.Core.Repositories.Tariffs;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories.Tariffs {
    public class TariffBaseUnitCostTypeRepository : Repository<TariffBaseUnitCostType>, ITariffBaseUnitCostTypeRepository {
        public TariffBaseUnitCostTypeRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}