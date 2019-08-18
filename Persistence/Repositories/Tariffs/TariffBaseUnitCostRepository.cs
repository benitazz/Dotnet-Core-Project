using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using MedicalEngineMicroService.Core.Repositories.Tariffs;
using MedicalEngineMicroService.Persistence;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Tariffs
{
    public class TariffBaseUnitCostRepository : Repository<TariffBaseUnitCost>, ITariffBaseUnitCostRepository {
        public TariffBaseUnitCostRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}