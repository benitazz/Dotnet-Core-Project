using System.Threading.Tasks;

namespace MedicalBilingMicroservice.Core
{
    public interface IUnitOfWork
    {
        Task CompletedAsync(); 
    }
}