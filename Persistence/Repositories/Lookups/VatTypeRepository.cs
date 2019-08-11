
using MedicalBilingBackEnd.Core.Models.Entities.Lookups;
using MedicalBilingBackEnd.Core.Repositories.Lookups;
using MedicalBilingMicroservice.Persistence;
using switch_api.Persistence.Repositories;

namespace MedicalBilingBackEnd.Persistence.Repositories.Lookups
{
    public class VatTypeRepository : Repository<VatType>, IVatTypeRepository
    {
        public VatTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}