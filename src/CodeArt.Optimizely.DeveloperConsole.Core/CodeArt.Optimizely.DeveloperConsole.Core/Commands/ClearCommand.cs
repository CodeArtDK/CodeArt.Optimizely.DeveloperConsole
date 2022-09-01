using CodeArt.Optimizely.DeveloperConsole.Attributes;
using CodeArt.Optimizely.DeveloperConsole.Core;
using CodeArt.Optimizely.DeveloperConsole.Interfaces;
using CodeArt.Optimizely.DeveloperConsole.Models;
using EPiServer.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeArt.Optimizely.DeveloperConsole.Commands
{
    [Command(Keyword = "clear", Description ="Clears the log for this session")]
    public class ClearCommand : IConsoleCommand, ILogAwareCommand
    {
        public List<CommandLog> Log { get; set; }

        public string Execute(params string[] parameters)
        {
            Log.Clear();
            return "Log cleared";
        }
    }
}
