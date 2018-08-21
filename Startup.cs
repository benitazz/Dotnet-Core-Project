using System.Linq;
using System.Text;
using AutoMapper;
using FluentValidation.AspNetCore;
using MedicalBilingMicroservice.Common.Extensions;
using MedicalBilingMicroservice.Core.Models.Auth;
using MedicalBilingMicroservice.Persistence;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData.Formatter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Net.Http.Headers;

namespace MedicalBilingMicroservice
{
    public class Startup {
        private const string SecretKey = "iNivDmHLpUA223sqsfhqGbMRdRj1PVkH"; // todo: get this from somewhere secure
        private readonly SymmetricSecurityKey _signingKey = new SymmetricSecurityKey (Encoding.ASCII.GetBytes (SecretKey));

        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {

            services.AddDbContext<ApplicationDbContext> (options => options.UseSqlServer (Configuration.GetConnectionString ("Default")));
            services.ConfigureServices ();
            var jwtAppSettingOptions = Configuration.GetSection (nameof (JwtIssuerOptions));
            services.ConfigureJwtServices (jwtAppSettingOptions, this._signingKey);

            services.AddAutoMapper ();
            services.AddOData ();
            services.AddMvc ().SetCompatibilityVersion (CompatibilityVersion.Version_2_1).AddFluentValidation ();
            // services.AddMvc ().AddFluentValidation (fv => fv.RegisterValidatorsFromAssemblyContaining<Startup> ());
            services.ConfigureSwaggerServices ();
            services.ConfigureValidationServices();

             // Workaround: https://github.com/OData/WebApi/issues/1177
            services.AddMvcCore(options =>
            {
                foreach (var outputFormatter in options.OutputFormatters.OfType<ODataOutputFormatter>().Where(_ => _.SupportedMediaTypes.Count == 0))
                {
                    outputFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/prs.odatatestxx-odata"));
                }
                foreach (var inputFormatter in options.InputFormatters.OfType<ODataInputFormatter>().Where(_ => _.SupportedMediaTypes.Count == 0))
                {
                    inputFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/prs.odatatestxx-odata"));
                }
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            } else {
                app.UseHsts ();
            }

            app.SwaggerUiConfiguration();
            app.UseHttpsRedirection ();
            app.UseStaticFiles ();
            app.UseAuthentication ();
            app.UseMvc (routes => {
                routes.Select ().Expand ().Filter ().OrderBy ().MaxTop (null).Count ();
                var odataBuilder = new ODataConventionModelBuilder (app.ApplicationServices);
                routes.MapODataServiceRoute ("odata", "api",odataBuilder.GetEdmModel ());
                /*routes.MapODataServiceRoute ("odata", "api",
                    b => b.AddService (OdataServiceLifetime.Singleton, sp => odataBuilder.GetEdmModel ())
                    .AddService<ODataUriResolver> (OdataServiceLifetime.Singleton, sp => new CaseInsensitiveResolver ()));*/
                routes.EnableDependencyInjection ();
            });
        }
    }
}