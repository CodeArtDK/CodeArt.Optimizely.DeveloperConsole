using CodeArt.Optimizely.DeveloperConsole.Attributes;
using CodeArt.Optimizely.DeveloperConsole.Interfaces;
using EPiServer.Framework.Cache;
using EPiServer.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeArt.Optimizely.DeveloperConsole.Commands
{

    [Command(Keyword ="objectcache", Description ="")]
    public class ObjectCacheCommand : IConsoleCommand, IOutputCommand, IConsoleOutputCommand
    {
        public event CommandOutput OnCommandOutput;
        public event OutputToConsoleHandler OutputToConsole;

        private readonly ISynchronizedObjectInstanceCache _cache;

        public ObjectCacheCommand(ISynchronizedObjectInstanceCache synchronizedObjectInstanceCache)
        {
            _cache = synchronizedObjectInstanceCache;
        }

        public string Execute(params string[] parameters)
        {
            
            throw new NotImplementedException();
        }
    }
}
