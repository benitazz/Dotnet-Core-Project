using System.Threading.Tasks;
using MedicalBilingMicroservice.Core;
using MedicalBilingMicroservice.Persistence;

namespace MedicalBilingMicroservice.Persistence
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly ApplicationDbContext switchApiDataContext;
        public UnitOfWork(ApplicationDbContext switchApiDataContext)
        {
            this.switchApiDataContext = switchApiDataContext;
        }

        public async Task CompletedAsync()
        {
            await this.switchApiDataContext.SaveChangesAsync();
            
        }

        public void Dispose()
        {
            this.switchApiDataContext.Dispose();
        }
    }
}