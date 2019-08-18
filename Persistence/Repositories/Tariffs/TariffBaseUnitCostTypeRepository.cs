using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using MedicalEngineMicroService.Core.Repositories.Tariffs;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Tariffs {
    public class TariffBaseUnitCostTypeRepository : Repository<TariffBaseUnitCostType>, ITariffBaseUnitCostTypeRepository {
        public TariffBaseUnitCostTypeRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}