using System.Threading.Tasks;
using MedicalEngineMicroService.Core.Models.Entities.Medical;

namespace MedicalEngineMicroService.Core.Repositories.Medical {
    public interface ITariffTypeRepository : IRepository<TariffType> {
        Task<TariffType> GetTariffTypeByName (string name);

        Task<TariffType> GetTariffTypeByName (string name, int id);
    }
}