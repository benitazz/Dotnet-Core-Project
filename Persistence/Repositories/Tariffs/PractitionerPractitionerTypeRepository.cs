using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using MedicalBilingMicroservice.Core.Repositories.Tariffs;
using Microsoft.EntityFrameworkCore;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories.Tariffs {
    public class PractitionerPractitionerTypeRepository : Repository<PractitionerPractitionerType>, IPractitionerPractitionerTypeRepository
    {
        public PractitionerPractitionerTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}