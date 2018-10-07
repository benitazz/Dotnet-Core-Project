using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using MedicalBilingBackEnd.Core.Repositories.Tariffs;
using MedicalBilingMicroservice.Persistence;
using Microsoft.EntityFrameworkCore;
using switch_api.Persistence.Repositories;

namespace MedicalBilingBackEnd.Persistence.Repositories.Tariffs
{
    public class TariffUnitCostRepository : Repository<TariffUnitCost>, ITariffUnitCostRepository
    {
        public TariffUnitCostRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}