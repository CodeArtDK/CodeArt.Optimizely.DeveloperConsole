using System;
using System.Linq;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace CodeArt.Optimizely.DeveloperConsole.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class DeveloperConsoleInit : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            //Add initialization logic, this method is called once after CMS has been initialized

            //Register routes
            //var d1 = new RouteValueDictionary();
            //d1.Add("controller", "Console");
            //RouteTable.Routes.Add("DeveloperConsoleWeb",new Route("api/DeveloperConsole/Web/{action}", d1, new MvcRouteHandler()));
            //var d2 = new RouteValueDictionary();
            //d2.Add("controller", "CLI");
            //RouteTable.Routes.Add("DeveloperConsoleCLI", new Route("api/DeveloperConsole/CLI/{action}", d2, new MvcRouteHandler()));

        }

        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
        }
    }
}