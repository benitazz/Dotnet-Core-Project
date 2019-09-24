using MedicalEngineMicroService.Core.Models.Entities.Medical;
using MedicalEngineMicroService.Core.Repositories.Medical;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Medical {
    public class TariffBaseUnitCostTypeRepository : Repository<TariffBaseUnitCostType>, ITariffBaseUnitCostTypeRepository {
        public TariffBaseUnitCostTypeRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}