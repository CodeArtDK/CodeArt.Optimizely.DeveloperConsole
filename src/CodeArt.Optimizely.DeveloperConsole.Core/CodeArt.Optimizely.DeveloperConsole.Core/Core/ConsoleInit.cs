using System;
using System.Linq;
using CodeArt.Optimizely.DeveloperConsole.Models;
using CodeArt.Optimizely.DeveloperConsole.Interfaces;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using EPiServer.Security;

namespace CodeArt.Optimizely.DeveloperConsole.Core
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class ConsoleInit : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            //Add initialization logic, this method is called once after CMS has been initialized
            context.InitComplete += Context_InitComplete;

            //TODO: Register route

        }

        private void Context_InitComplete(object sender, EventArgs e)
        {
            var cmdMgr = ServiceLocator.Current.GetInstance<CommandManager>();
            var type = typeof(IConsoleCommand);
            try
            {
                var types = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(s => s.GetTypes())
                    .Where(p => type.IsAssignableFrom(p) && !p.IsInterface);

                foreach (var t in types)
                {
                    var ccd = new ConsoleCommandDescriptor(t);
                    //TODO: Make resilient to duplicates?
                    cmdMgr.Commands.Add(ccd.Keyword.ToLower(), ccd);
                }
            } catch(Exception exc)
            {
                //For now, do nothing. Potentially output it
            }
        }

        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
        }
    }
}