using MedicalBilingMicroservice.Core.Models.Entities.Tariffs;
using MedicalBilingMicroservice.Core.Repositories.Tariffs;
using Microsoft.EntityFrameworkCore;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories.Tariffs {
    public class PractitionerRepository : Repository<Practitioner>, IPractitionerRepository
    {
        public PractitionerRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}