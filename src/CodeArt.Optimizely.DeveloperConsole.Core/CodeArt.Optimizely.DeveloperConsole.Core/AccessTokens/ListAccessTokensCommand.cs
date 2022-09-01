using CodeArt.Optimizely.DeveloperConsole.Attributes;
using CodeArt.Optimizely.DeveloperConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeArt.Optimizely.DeveloperConsole.AccessTokens
{
    [Command(Keyword = "listaccesstoken", Group = CommandGroups.ACCESSTOKENS, Description = "Lists access tokens")]
    public class ListAccessTokenCommand : IConsoleCommand, IConsoleOutputCommand
    {
        public event OutputToConsoleHandler OutputToConsole;

        [CommandParameter]
        public bool ShowAllTokens { get; set; }

        public string Execute(params string[] parameters)
        {
            int cnt = 0;
            AccessTokenStore store = new AccessTokenStore();
            foreach(var at in store.ListTokens(ShowAllTokens))
            {
                OutputToConsole?.Invoke(this, $"{at.Id}\t{at.Owner}\t{at.Created.ToShortDateString()}");
                cnt++;
            }

            
            return $"{cnt} access token listed. ";
        }
    }
}