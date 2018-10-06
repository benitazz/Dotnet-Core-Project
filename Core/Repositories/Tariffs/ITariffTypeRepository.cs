using System.Threading.Tasks;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using switch_api.Core.Repositories;

namespace MedicalBilingBackEnd.Core.Repositories.Tariffs
{
    public interface ITariffTypeRepository:  IRepository<TariffType>
    {
         Task<TariffType> GetTariffTypeByName(string name);
    }
}