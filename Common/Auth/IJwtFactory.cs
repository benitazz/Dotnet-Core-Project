using System.Security.Claims;
using System.Threading.Tasks;

namespace MedicalEngineMicroService.Common.Auth {
    public interface IJwtFactory {
        Task<string> GenerateEncodedToken (string userName, ClaimsIdentity identity);
        ClaimsIdentity GenerateClaimsIdentity (string userName, string id);
    }
}