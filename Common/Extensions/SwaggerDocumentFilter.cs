using System.Collections.Generic;
using System.Linq;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace MedicalBilingMicroservice.Common.Extensions {
    public class SwaggerDocumentFilter : IDocumentFilter {
        public void Apply (SwaggerDocument swaggerDoc, DocumentFilterContext context) {
            var paths = swaggerDoc.Paths.OrderBy (e => e.Key).ToList ();
            swaggerDoc.Paths = paths.ToDictionary (e => e.Key, e => e.Value);

            swaggerDoc.Security = new List<IDictionary<string, IEnumerable<string>> > () {
                new Dictionary<string, IEnumerable<string>> () { { "Bearer", new string[] { } }, { "Basic", new string[] { } },
                }
            };
        }
    }
}