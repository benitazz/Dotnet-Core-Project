using System.Collections.Generic;
using System.Threading.Tasks;
using MedicalBilingMicroservice.Core.Models.Entities.Users;
using switch_api.Core.Repositories;

namespace MedicalBilingMicroservice.Core.Repositories {
    public interface IUserRepository : IRepository<ApplicationUser> {
        Task<ApplicationUser> GetUserById (string id);

        Task<List<ApplicationUser>> GetAllUsers ();
    }
}