using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using MedicalBilingBackEnd.Core.Repositories.Tariffs;
using MedicalBilingMicroservice.Persistence;
using switch_api.Persistence.Repositories;

namespace MedicalBilingBackEnd.Persistence.Repositories.Tariffs
{
    public class TariffBaseUnitCostRepository : Repository<TariffBaseUnitCost>, ITariffBaseUnitCostRepository {
        public TariffBaseUnitCostRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}