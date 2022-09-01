using CodeArt.Optimizely.DeveloperConsole.Attributes;
using CodeArt.Optimizely.DeveloperConsole.Interfaces;
using EPiServer;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeArt.Optimizely.DeveloperConsole.Commands
{
    [Command(Keyword = "sites", Description = "Lists all registered sites")]
    public class SitesCommand : IOutputCommand
    {
        public event CommandOutput OnCommandOutput;

        private readonly ISiteDefinitionRepository _siteRepo;

        public SitesCommand(ISiteDefinitionRepository siteDefinitionRepository)
        {
            _siteRepo = siteDefinitionRepository;
        }

        public string Execute(params string[] parameters)
        {
            int cnt = 0;


            foreach (var r in _siteRepo.List())
            {
                OnCommandOutput?.Invoke(this, r);
                cnt++;
            }

            return $"Done, listing {cnt} sites";
        }
    }
}
    
