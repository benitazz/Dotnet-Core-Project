using System.Threading.Tasks;
using MedicalEngineMicroService.Core;
using MedicalEngineMicroService.Persistence;

namespace MedicalEngineMicroService.Persistence
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly ApplicationDbContext MedicalEngineMicroServiceDataContext;
        public UnitOfWork(ApplicationDbContext MedicalEngineMicroServiceDataContext)
        {
            this.MedicalEngineMicroServiceDataContext = MedicalEngineMicroServiceDataContext;
        }

        public async Task CompletedAsync()
        {
            await this.MedicalEngineMicroServiceDataContext.SaveChangesAsync();
            
        }

        public void Dispose()
        {
            this.MedicalEngineMicroServiceDataContext.Dispose();
        }
    }
}