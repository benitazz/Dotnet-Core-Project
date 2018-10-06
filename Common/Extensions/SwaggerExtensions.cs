using System;
using System.Linq;
using MedicalBilingBackEnd.Common.Attributes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace MedicalBilingMicroservice.Common.Extensions
{
    public static class SwaggerExtensions
    {
        public static IServiceCollection ConfigureSwaggerServices(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v3", new Info
                {
                    Version = "v3",
                    Title = "Medical Biling API's",
                    Description = "Medical Biling API's",
                    Contact = new Contact { Name = "Master Ben", Email = "benitazz@gmail.com" }
                });

                c.DescribeAllEnumsAsStrings();
                c.EnableAnnotations();
                //c.OrderActionsBy((apiDesc) => $"{apiDesc.ActionDescriptor.RouteValues["controller"]}_{apiDesc.HttpMethod}");
                //c.TagActionsBy(api => api.GroupName);
                c.TagActionsBy(api => api.GroupBySwaggerGroupAttribute());
                c.IncludeXmlComments(string.Format(@"{0}\MedicalBiling.XML", AppDomain.CurrentDomain.BaseDirectory));
                c.OperationFilter<OdataSwaggerFilters>();
                c.DocumentFilter<SwaggerDocumentFilter>();
                // c.OrderActionsBy();
                c.AddSecurityDefinition("Bearer", new ApiKeyScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    In = "header",
                    Type = "apiKey"
                });
            });
            return services;
        }

        public static IApplicationBuilder SwaggerUiConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger(c =>
            {
                c.PreSerializeFilters.Add((swaggerDoc, httpReq) => swaggerDoc.Host = httpReq.Host.Value);
            });

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v3/swagger.json", "MedicalBilling API V3");
                c.DocExpansion(DocExpansion.None);
                c.ShowExtensions();
                c.EnableFilter();
                c.InjectStylesheet(@"/swagger-ui/Swagger-ui-style.css");
            });

            return app;
        }

        public static string GroupBySwaggerGroupAttribute(this ApiDescription api)
        {

            // var t  = api.GetType().GetCustomAttributes(true).SingleOrDefault(attribute => attribute is SwaggerGroupAttribute);

            var groupNameAttribute =
                (SwaggerGroupAttribute)api.ControllerAttributes()
                .SingleOrDefault(attribute => attribute is SwaggerGroupAttribute);

            /*var groupNameAttribute =
                (SwaggerGroupAttribute)api.TryGetMethodInfo()
                .SingleOrDefault(attribute => attribute is SwaggerGroupAttribute);*/

            var actionDescriptor = api.GetProperty<ControllerActionDescriptor>();

            if (actionDescriptor == null)
            {
                actionDescriptor = api.ActionDescriptor as ControllerActionDescriptor;
                api.SetProperty(actionDescriptor);
            }

            return groupNameAttribute != null ? groupNameAttribute.GroupName : actionDescriptor?.ControllerName;
        }


        /*public static bool TryGetControllerTypeInfo(this ApiDescription apiDescription, out ControllerTypeInfo controllerTypeInfo)
        {
            var controllerActionDescriptor = apiDescription.ActionDescriptor as ControllerActionDescriptor;

            controllerTypeInfo = controllerActionDescriptor?.ControllerTypeInfo;

            return (controllerTypeInfo != null);
        }*/

    }
}