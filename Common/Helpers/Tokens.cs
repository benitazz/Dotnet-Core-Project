using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MedicalBilingMicroservice.Common.Auth;
using MedicalBilingMicroservice.Core.Models.Auth;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace MedicalBilingMicroservice.Common.Helpers {
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