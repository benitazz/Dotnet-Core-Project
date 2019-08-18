using System.Threading.Tasks;

namespace MedicalEngineMicroService.Core
{
    public interface IUnitOfWork
    {
        Task CompletedAsync(); 
    }
}