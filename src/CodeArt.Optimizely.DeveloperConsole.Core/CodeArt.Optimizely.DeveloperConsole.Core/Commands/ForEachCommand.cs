using CodeArt.Optimizely.DeveloperConsole.Attributes;
using CodeArt.Optimizely.DeveloperConsole.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeArt.Optimizely.DeveloperConsole.Commands
{
    [Command(Keyword ="foreach",Description ="Iterates through incoming lists", Group =CommandGroups.CONTROL)]
    public class ForEachCommand : IInputCommand, IOutputCommand
    {
        public event CommandOutput OnCommandOutput;

        public string Execute(params string[] parameters)
        {
            return null;
        }

        public void Initialize(IOutputCommand Source, params string[] parameters)
        {
            Source.OnCommandOutput += Source_OnCommandOutput;
        }

        private void Source_OnCommandOutput(IOutputCommand sender, object output)
        {
            if(output is IEnumerable)
            {
                foreach (var o in (output as IEnumerable))
                    OnCommandOutput?.Invoke(this, o);
            }
        }
    }
}
