using System.Threading.Tasks;
using MedicalEngineMicroService.Core.Models.Entities.Tariffs;
using MedicalEngineMicroService.Core.Repositories;

namespace MedicalEngineMicroService.Core.Repositories.Tariffs {
    public interface ITariffTypeRepository : IRepository<TariffType> {
        Task<TariffType> GetTariffTypeByName (string name);

        Task<TariffType> GetTariffTypeByName (string name, int id);
    }
}