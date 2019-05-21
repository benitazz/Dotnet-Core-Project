using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using FluentValidation.AspNetCore;
using MedicalBilingBackEnd.Common.Extensions;
using MedicalBilingMicroservic.Core.Models;
using MedicalBilingMicroservice.Common.Extensions;
using MedicalBilingMicroservice.Core.Models;
using MedicalBilingMicroservice.Core.Models.Auth;
using MedicalBilingMicroservice.Core.Models.Entities.Users;
using MedicalBilingMicroservice.Persistence;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData.Formatter;
using Microsoft.AspNet.OData.Routing.Conventions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Net.Http.Headers;
using Microsoft.OData;
using Microsoft.OData.UriParser;

namespace MedicalBilingMicroservice {
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
            services.Configure<AuthMessageSenderOptions> (Configuration.GetSection (nameof (AuthMessageSenderOptions)));
            services.Configure<FrontEndApplication> (Configuration.GetSection (nameof (FrontEndApplication)));

            services.AddAutoMapper ();
            services.AddOData ();
            services.AddIdentity<ApplicationUser, ApplicationRole> (
                    options => {
                        options.Stores.MaxLengthForKeys = 128;
                        options.SignIn.RequireConfirmedEmail = true;
                    })
                .AddEntityFrameworkStores<ApplicationDbContext> ()
                .AddDefaultUI ()
                .AddDefaultTokenProviders ();

            services.AddCors (options => {
                options.AddPolicy ("AllowAll",
                    builder => {
                        builder
                            .AllowAnyOrigin ()
                            .AllowAnyMethod ()
                            .AllowAnyHeader ();
                    });
            });

            /* services.AddMvc (c =>
                c.Conventions.Add(new ApiExplorerGroupPerVersionConvention())*/
            services.AddMvc ().SetCompatibilityVersion (CompatibilityVersion.Version_2_1).AddFluentValidation ();
            services.AddSingleton<IEmailSender, EmailSender> ();
            services.Configure<AuthMessageSenderOptions> (Configuration);

            services.ConfigureSwaggerServices ();
            services.ConfigureValidationServices ();

            // Workaround: https://github.com/OData/WebApi/issues/1177
            services.AddMvcCore (options => {
                foreach (var outputFormatter in options.OutputFormatters.OfType<ODataOutputFormatter> ().Where (_ => _.SupportedMediaTypes.Count == 0)) {
                    outputFormatter.SupportedMediaTypes.Add (new MediaTypeHeaderValue ("application/prs.odatatestxx-odata"));
                }
                foreach (var inputFormatter in options.InputFormatters.OfType<ODataInputFormatter> ().Where (_ => _.SupportedMediaTypes.Count == 0)) {
                    inputFormatter.SupportedMediaTypes.Add (new MediaTypeHeaderValue ("application/prs.odatatestxx-odata"));
                }
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app,
            IHostingEnvironment env,
            ApplicationDbContext context,
            RoleManager<ApplicationRole> roleManager,
            UserManager<ApplicationUser> userManager) {

            /*if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }*/

            app.UseDeveloperExceptionPage ();

            app.SwaggerUiConfiguration ();
            app.UseSwaggerUI (c => {
                /*c.SwaggerEndpoint ("/swagger/v2/swagger.json", "BulkPayment API V2");
                c.DocExpansion (DocExpansion.None);*/
                c.ShowExtensions ();
                c.EnableFilter ();
                c.InjectStylesheet (@"/swagger-ui/Swagger-ui-style.css");
                c.SwaggerEndpoint ("/swagger/v3/swagger.json", "Sample API");
            });

            //app.UseHttpsRedirection();
            app.UseStaticFiles ();
            app.UseCors ("AllowAll");

            app.UseAuthentication ();
            app.UseMvc (routes => {
                routes.Select ().Expand ().Filter ().OrderBy ().MaxTop (null).Count ();
                var odataBuilder = new ODataConventionModelBuilder (app.ApplicationServices);
                routes.MapODataServiceRoute ("odata", "odata", odataBuilder.GetEdmModel ());
                /*routes.MapODataServiceRoute ("odata", "api",
                    builder => b.AddService (OdataServiceLifetime.Singleton, sp => odataBuilder.GetEdmModel ())
                    .AddService<ODataUriResolver> (OdataServiceLifetime.Singleton, sp => new CaseInsensitiveResolver ()));*/

                routes.EnableDependencyInjection ();
                /*configuration.MapODataServiceRoute("odata", "odata",
                    builder =>
                        builder.AddService(Microsoft.OData.ServiceLifetime.Singleton, sp => odataBuilder.GetEdmModel())
                            .AddService<IEnumerable<IODataRoutingConvention>>(Microsoft.OData.ServiceLifetime.Singleton, sp =>
                                ODataRoutingConventions.CreateDefaultWithAttributeRouting("odata", configuration))
                            .AddService<ODataUriResolver>(Microsoft.OData.ServiceLifetime.Singleton, sp => new CaseInsensitiveResolver()));*/
            });

            seedData.Initialize (context, userManager, roleManager).Wait ();
        }
    }
}