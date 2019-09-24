using MedicalEngineMicroService.Core.Models.Entities.Medical;
using MedicalEngineMicroService.Core.Repositories.Medical;
using MedicalEngineMicroService.Persistence;
using Microsoft.EntityFrameworkCore;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Medical
{
    public class TariffRepository : Repository<Tariff>, ITariffRepository
    {
        public TariffRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}