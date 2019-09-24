using System;
using System.Linq;
using System.Threading.Tasks;
using MedicalEngineMicroService.Common.Extensions;
using MedicalEngineMicroService.Core.Models.Entities.Medical;
using MedicalEngineMicroService.Core.Repositories.Medical;
using MedicalEngineMicroService.Persistence;
using Microsoft.EntityFrameworkCore;
using MedicalEngineMicroService.Persistence.Repositories;

namespace MedicalEngineMicroService.Persistence.Repositories.Medical
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