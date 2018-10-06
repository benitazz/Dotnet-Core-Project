using System;
using System.Linq;
using System.Threading.Tasks;
using MedicalBilingBackEnd.Common.Extensions;
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
            name = name.ToUpperCaseRemoveWhiteSpace();

            return await this.ApplicationDbContext.TariffTypes
                 .SingleOrDefaultAsync(tariff => tariff.NormalizedName == name);
        }

        public async Task<TariffType> GetTariffTypeByName(string name, int id)
        {
            name = name.ToUpperCaseRemoveWhiteSpace();

            return await this.ApplicationDbContext.TariffTypes
                 .SingleOrDefaultAsync(tariff => tariff.NormalizedName == name && tariff.Id != id);
        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return this.dbContext as ApplicationDbContext; }
        }
    }
}