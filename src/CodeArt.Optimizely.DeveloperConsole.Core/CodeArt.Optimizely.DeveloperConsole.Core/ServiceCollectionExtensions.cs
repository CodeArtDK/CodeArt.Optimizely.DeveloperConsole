using EPiServer.ServiceLocation;
using EPiServer.Shell.Modules;
using EPiServer.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeArt.Optimizely.DeveloperConsole
{
    public static class ServiceCollectionExtensions
    {
        public const string MODULENAME = "CodeArt.Optimizely.DeveloperConsole";
        public static IServiceCollection AddDeveloperConsole(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();

            //services.AddAuthorization(options => options.AddPolicy())
            //services.AddAuthorization(authoptions => {
            //    authoptions.AddPolicy("codeart:jupiterenabled", policy => policy.RequireAssertion((context) => options.Enabled));
            //    authoptions.AddPolicy("codeart:jupiterwebeditorenabled", policy => policy.RequireAssertion((context) => options.EnableWebEditor));
            //    authoptions.AddPolicy("codeart:jupiterwebspacechangesenabled", policy => policy.RequireAssertion((context) => options.EnableWebSpaceChanges));
            //});

            //TODO: change default setting for caching of static files on client

            services.Configure<ProtectedModuleOptions>(
                pm =>
                {
                    if (!pm.Items.Any(i =>
                        i.Name.Equals(MODULENAME, System.StringComparison.OrdinalIgnoreCase)))
                    {
                        pm.Items.Add(new ModuleDetails() { Name = MODULENAME });
                    }
                });




            return services;
        }
    }
}

