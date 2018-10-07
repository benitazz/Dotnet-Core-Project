using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using MedicalBilingBackEnd.Core.Repositories.Tariffs;
using MedicalBilingMicroservice.Persistence;
using Microsoft.EntityFrameworkCore;
using switch_api.Persistence.Repositories;

namespace MedicalBilingBackEnd.Persistence.Repositories.Tariffs
{
    public class TariffRepository : Repository<Tariff>, ITariffRepository
    {
        public TariffRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}