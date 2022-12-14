using CodeArt.Optimizely.DeveloperConsole.Attributes;
using CodeArt.Optimizely.DeveloperConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeArt.Optimizely.DeveloperConsole.Commands
{
    [Command(Keyword ="skip")]
    public class SkipCommand : IOutputCommand, IInputCommand
    {

        public event CommandOutput OnCommandOutput;

        public int Count { get; set; }
        private int _seen;

        public string Execute(params string[] parameters)
        {
            

            return string.Empty;
        }

        private void Source_OnCommandOutput(IOutputCommand sender, object output)
        {
            _seen++;
            if (_seen > Count) OnCommandOutput?.Invoke(this, output);
        }

        public void Initialize(IOutputCommand Source, params string[] parameters)
        {
            _seen = 0;
            if (parameters.Length == 1) Count = int.Parse(parameters[0]);
            if (Source != null)
            {
                Source.OnCommandOutput += Source_OnCommandOutput;
            }
        }
    }
}
