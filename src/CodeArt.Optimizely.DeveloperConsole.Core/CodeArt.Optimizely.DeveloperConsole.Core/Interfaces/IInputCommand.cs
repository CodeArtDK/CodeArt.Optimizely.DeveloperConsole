using CodeArt.Optimizely.DeveloperConsole.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeArt.Optimizely.DeveloperConsole.Interfaces
{
    public interface IInputCommand : IConsoleCommand
    {
        void Initialize(IOutputCommand Source, params string[] parameters);
    }
}
