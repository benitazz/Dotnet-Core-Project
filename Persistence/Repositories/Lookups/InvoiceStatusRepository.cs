using MedicalEngineMicroService.Core.Models.Entities.Lookups;
using MedicalEngineMicroService.Core.Repositories.Lookups;
using MedicalEngineMicroService.Persistence;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Lookups
{
    public class InvoiceStatusRepository : Repository<InvoiceStatus>, IInvoiceStatusRepository
    {
        public InvoiceStatusRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}