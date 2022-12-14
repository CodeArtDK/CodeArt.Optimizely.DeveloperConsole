using CodeArt.Optimizely.DeveloperConsole.Attributes;
using CodeArt.Optimizely.DeveloperConsole.Interfaces;
using EPiServer.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeArt.Optimizely.DeveloperConsole.Commands
{
    [Command(Keyword ="tolog",Description ="Sends content to log")]
    public class ToLogCommand : IConsoleCommand, IInputCommand
    {
        private static readonly EPiServer.Logging.ILogger log = LogManager.GetLogger();

        [CommandParameter]
        public Level Level { get; set; }

        [CommandParameter]
        public string Message { get; set; }

        public string Execute(params string[] parameters)
        {
            if (!string.IsNullOrEmpty(Message)) log.Log(Level, Message);
            return "Written to log";
        }

        public void Initialize(IOutputCommand Source, params string[] parameters)
        {
            Source.OnCommandOutput += Source_OnCommandOutput;
        }

        private void Source_OnCommandOutput(IOutputCommand sender, object output)
        {
            log.Log(Level, output.ToString());
        }

        public ToLogCommand()
        {
            Level = Level.Error;
        }
    }
}
