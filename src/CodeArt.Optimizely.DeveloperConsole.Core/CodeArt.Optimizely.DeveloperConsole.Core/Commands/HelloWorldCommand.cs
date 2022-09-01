using CodeArt.Optimizely.DeveloperConsole.Attributes;
using CodeArt.Optimizely.DeveloperConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeArt.Optimizely.DeveloperConsole.Commands
{
    [Command(Keyword ="hello", Description ="The classic hello world example command")]
    public class HelloWorldCommand : IConsoleCommand
    {
        
        [CommandParameter]
        public string Name { get; set; }

        /// <summary>
        /// Returns a string that will be returned as output.
        /// </summary>
        /// <returns></returns>
        public string Execute(params string[] parameters)
        {
            if (string.IsNullOrEmpty(Name) && parameters.Length == 1) Name = parameters.First();
            return "Hello " + Name;
        }
    }
}