
using MedicalBilingMicroservice.Core.Models.Entities.Users;
using MedicalBilingMicroservice.Core.Repositories;
using switch_api.Persistence;
using switch_api.Persistence.Repositories;

namespace MedicalBilingMicroservice.Persistence.Repositories {
    public class UserRepository : Repository<ApplicationUser>, IUserRepository {
        public UserRepository (ApplicationDbContext switchDataContext) : base (switchDataContext) {

        }
    }
}