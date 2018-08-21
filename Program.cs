using System;
using System.Reflection;
using MedicalBilingMicroservice;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace MedicalBilingMicroservice {
    public class Program {
        public static void Main (string[] args) {
            CreateWebHostBuilder (args).Build ().Run ();
        }

        public static IWebHostBuilder CreateWebHostBuilder (string[] args) =>
            WebHost.CreateDefaultBuilder (args)
            .UseEnvironment ("Development")
            .ConfigureAppConfiguration ((context, builder) => {
                var env = context.HostingEnvironment;

                builder.AddJsonFile ("appsettings.json", optional : true, reloadOnChange : true)
                    .AddJsonFile ($"appsettings.{env.EnvironmentName}.json", optional : true, reloadOnChange : true)
                    .AddJsonFile ($"appsettings.{Environment.MachineName}.json", optional : true, reloadOnChange : true);

                if (env.IsDevelopment ()) {
                    var appAssembly = Assembly.Load (
                        new AssemblyName (env.ApplicationName));
                    if (appAssembly != null) {
                        builder.AddUserSecrets (appAssembly, optional : true);
                    }
                }

                builder.AddEnvironmentVariables ();

                if (args != null) {
                    builder.AddCommandLine (args);
                }
            })
            .UseStartup<Startup> ();
    }
}