using CodeArt.Optimizely.DeveloperConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeArt.Optimizely.DeveloperConsole.Commands
{
    public class LoadLocalFileCommand : IConsoleCommand, IOutputCommand
    {
        public event CommandOutput OnCommandOutput;

        public string Execute(params string[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
