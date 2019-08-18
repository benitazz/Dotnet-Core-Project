using System;
using MedicalEngineMicroService.Common.Helpers;
using MedicalEngineMicroService.Core.Models.Auth;
using MedicalEngineMicroService.Core.Models.Entities.Users;
using MedicalEngineMicroService.Persistence;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace MedicalEngineMicroService.Common.Extensions
{
    public static class JwtExtension {
        public static IServiceCollection ConfigureJwtServices (this IServiceCollection services,
            IConfigurationSection jwtAppSettingOptions, SecurityKey signingKey) {

            // Configure JwtIssuerOptions
            services.Configure<JwtIssuerOptions> (options => {
                options.Issuer = jwtAppSettingOptions[nameof (JwtIssuerOptions.Issuer)];
                options.Audience = jwtAppSettingOptions[nameof (JwtIssuerOptions.Audience)];
                options.SigningCredentials = new SigningCredentials (signingKey, SecurityAlgorithms.HmacSha256);
            });

            var tokenValidationParameters = new TokenValidationParameters {
                ValidateIssuer = true,
                ValidIssuer = jwtAppSettingOptions[nameof (JwtIssuerOptions.Issuer)],

                ValidateAudience = true,
                ValidAudience = jwtAppSettingOptions[nameof (JwtIssuerOptions.Audience)],

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = signingKey,

                RequireExpirationTime = false,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            };

            services.AddAuthentication (options => {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer (configureOptions => {
                configureOptions.ClaimsIssuer = jwtAppSettingOptions[nameof (JwtIssuerOptions.Issuer)];
                configureOptions.TokenValidationParameters = tokenValidationParameters;
                configureOptions.SaveToken = true;
            });

            // api user claim policy
            services.AddAuthorization (options => {
                options.AddPolicy ("ApiUser", policy => policy.RequireClaim (Constants.Strings.JwtClaimIdentifiers.Rol, Constants.Strings.JwtClaims.ApiAccess));
            });

            // add identity
            var builder = services.AddIdentityCore<ApplicationUser> (o => {
                // configure identity options
                o.Password.RequireDigit = false;
                o.Password.RequireLowercase = false;
                o.Password.RequireUppercase = false;
                o.Password.RequireNonAlphanumeric = false;
                o.Password.RequiredLength = 6;
            });
            builder = new IdentityBuilder (builder.UserType, typeof (ApplicationRole), builder.Services);
            builder.AddEntityFrameworkStores<ApplicationDbContext> ().AddDefaultTokenProviders ();

            return services;
        }
    }
}