using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MedicalEngineMicroService.Common.Auth;
using MedicalEngineMicroService.Core.Models.Auth;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace MedicalEngineMicroService.Common.Helpers {
    public class Tokens {
        public static async Task<string> GenerateJwt (
            ClaimsIdentity identity,
            IJwtFactory jwtFactory,
            string userName,
            IOptions<JwtIssuerOptions> jwtOptions,
            JsonSerializerSettings serializerSettings) {
            var response = new {
                id = identity.Claims.Single (c => c.Type == "id").Value,
                auth_token = await jwtFactory.GenerateEncodedToken (userName, identity),
                expires_in = (int) jwtOptions.Value.ValidFor.TotalSeconds
            };

            return JsonConvert.SerializeObject (response, serializerSettings);
        }
    }
}