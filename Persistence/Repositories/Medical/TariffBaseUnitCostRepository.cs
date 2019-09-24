using MedicalEngineMicroService.Core.Models.Entities.Medical;
using MedicalEngineMicroService.Core.Repositories.Medical;
using MedicalEngineMicroService.Persistence;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Medical
{
    public class TariffBaseUnitCostRepository : Repository<TariffBaseUnitCost>, ITariffBaseUnitCostRepository {
        public TariffBaseUnitCostRepository (ApplicationDbContext dbContext) : base (dbContext) { }
    }
}