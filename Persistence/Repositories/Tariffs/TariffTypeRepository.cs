using System;
using System.Threading.Tasks;
using MedicalBilingBackEnd.Core.Models.Entities.Tariffs;
using MedicalBilingBackEnd.Core.Repositories.Tariffs;
using MedicalBilingMicroservice.Persistence;
using Microsoft.EntityFrameworkCore;
using switch_api.Persistence.Repositories;

namespace MedicalBilingBackEnd.Persistence.Repositories.Tariffs
{
    public class TariffTypeRepository : Repository<TariffType>, ITariffTypeRepository
    {
        public TariffTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<TariffType> GetTariffTypeByName(string name)
        {
            return await this.ApplicationDbContext.TariffTypes
            .SingleOrDefaultAsync(
                tariff =>
                tariff.Name
                    .Replace(" ", string.Empty)
                    .Trim()
                    .Equals(name, StringComparison.InvariantCultureIgnoreCase));
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return this.dbContext as ApplicationDbContext; }
        }
    }
}