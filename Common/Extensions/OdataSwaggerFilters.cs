using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc.Filters;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace MedicalEngineMicroService.Common.Extensions
{
    public class OdataSwaggerFilters : IOperationFilter {
        public void Apply (Operation operation, OperationFilterContext context) {
            IList<FilterDescriptor> filterDescriptors = context.ApiDescription.ActionDescriptor.FilterDescriptors;
            bool isOdataQueryableResponse = 
                filterDescriptors.Select(filterInfo => filterInfo.Filter).Any(filter => filter is EnableQueryAttribute);

            if (isOdataQueryableResponse)
            {
                Dictionary<string, string> parameters = new Dictionary<string, string>()
                {
                    { "$filter", "A function that must evaluate to true for a record to be returned, eg { Id eq 1 }."},
                    { "$select", "Specifies a subset of properties to return."},
                    { "$top", "The max number of records."},
                    { "$skip", "The number of records to skip."},
                    { "$orderby", "Determines what values are used to order a collection of records."}
                };

                if (operation.Parameters == null)
                {
                    operation.Parameters = new List<IParameter>();
                }

                foreach (var pair in parameters)
                {
                    operation.Parameters.Add(new NonBodyParameter
                    {
                        Name = pair.Key,
                        Required = false,
                        Type = "string",
                        @In = "query",
                        Description = pair.Value
                    });
                }
            }
        }
    }
}