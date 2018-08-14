using System.Threading.Tasks;

namespace switch_api.Core
{
    public interface IUnitOfWork
    {
        Task CompletedAsync(); 
    }
}