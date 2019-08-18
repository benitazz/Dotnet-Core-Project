using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalEngineMicroService.Core.Models.Entities.Users;
using MedicalEngineMicroService.Core.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MedicalEngineMicroService.Persistence.Repositories
{
    public class UserRepository : Repository<ApplicationUser>, IUserRepository {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserRepository (ApplicationDbContext medicalEngineDataContext,
            UserManager<ApplicationUser> UserManager) : base (medicalEngineDataContext) {
            _userManager = UserManager;
        }

        public async Task<List<ApplicationUser>> GetAllUsers () {
            // https://stackoverflow.com/questions/51004516/net-core-2-1-identity-get-all-users-with-their-associated-roles
            var users = await this._userManager.Users
                .Include (u => u.UserRoles)
                .ThenInclude (ur => ur.Role).ToListAsync ();
            return users;
        }

        public async Task<ApplicationUser> GetUserById (string id) {
            var user = await this._userManager.Users
                .Where (user1 => user1.Id == id)
                .Include (u => u.UserRoles)
                .ThenInclude (ur => ur.Role).SingleOrDefaultAsync ();
            return user;
        }
    }
}