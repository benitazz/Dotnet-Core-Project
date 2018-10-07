using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using MedicalBilingBackEnd.Core.Repositories.Lookups;
using MedicalBilingMicroservice.Persistence;
using Microsoft.EntityFrameworkCore;
using switch_api.Persistence.Repositories;

namespace MedicalBilingBackEnd.Persistence.Repositories.Lookups
{
    public class VatRepository : Repository<Vat>, IVatRepository
    {
        public VatRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}