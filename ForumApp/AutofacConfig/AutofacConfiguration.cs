using Autofac;
using Autofac.Integration.WebApi;
using ForumApp.Common;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Compilation;
using System.Web.Http;
using System.Web.Mvc;

namespace ForumApp.AutofacConfig
{
    /// <summary>
    /// Configuration class autofac ioc container
    /// </summary>
    public static class AutofacConfiguration
    {
        /// <summary>
        /// Static method to register and load autofac in web during startup
        /// </summary>
        public static void Configure()
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;
            var executingAssembly = Assembly.GetExecutingAssembly();

            var domainAssemblies = BuildManager.GetReferencedAssemblies().Cast<Assembly>();
            //Assembly Modules

            builder.RegisterAssemblyModules<CustomModule>(domainAssemblies.ToArray());

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            //Components

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}