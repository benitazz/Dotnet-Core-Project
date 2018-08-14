using System.Threading.Tasks;
using switch_api.Core;

namespace switch_api.Persistence
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly SwitchDataContext switchApiDataContext;
        public UnitOfWork(SwitchDataContext switchApiDataContext)
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