using MedicalBilingMicroservice.Core.Models.Entities.Doctors;
using MedicalBilingMicroservice.Core.Repositories.Doctors;
using Microsoft.EntityFrameworkCore;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories.Doctors {
    public class PractionerRepository : Repository<Practioner>, IPractionerRepository
    {
        public PractionerRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}