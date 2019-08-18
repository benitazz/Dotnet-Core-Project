using System.Collections.Generic;
using System.Threading.Tasks;
using MedicalEngineMicroService.Core.Models.Entities.Users;
using MedicalEngineMicroService.Core.Repositories;

namespace MedicalEngineMicroService.Core.Repositories {
    public interface IUserRepository : IRepository<ApplicationUser> {
        Task<ApplicationUser> GetUserById (string id);

        Task<List<ApplicationUser>> GetAllUsers ();
    }
}