using CodeArt.Optimizely.DeveloperConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeArt.Optimizely.DeveloperConsole.Interfaces
{
    public delegate void CommandOutput(IOutputCommand sender, object output);

    public interface IOutputCommand : IConsoleCommand
    {
        event CommandOutput OnCommandOutput;
    }
}
