using CodeArt.Optimizely.DeveloperConsole.Attributes;
using CodeArt.Optimizely.DeveloperConsole.Interfaces;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTools.Console. Commands
{
    [Command(Keyword = "listdescendents", Description ="Lists all descendents below the node")]
    public class ListDescendentsCommand : IOutputCommand
    {
        public event CommandOutput OnCommandOutput;

        [CommandParameter]
        public string Parent { get; set; }

        private readonly IContentRepository _repo;

        public ListDescendentsCommand(IContentRepository contentRepository)
        {
            _repo = contentRepository;
        }

        public string Execute(params string[] parameters)
        {
            int cnt = 0;
            if (string.IsNullOrEmpty(Parent) && parameters.Any()) Parent = parameters.First();

            ContentReference start = ContentReference.StartPage;

            if (!string.IsNullOrEmpty(Parent))
            {
                if (Parent.ToLower() == "root") start = ContentReference.RootPage;
                else if (Parent.ToLower() == "globalblocks") start = ContentReference.GlobalBlockFolder;
                else if (Parent.ToLower() == "siteblocks") start = ContentReference.SiteBlockFolder;
                else start = ContentReference.Parse(Parent);
            }

            foreach(var r in _repo.GetDescendents(start))
            {
                OnCommandOutput?.Invoke(this, _repo.Get<IContent>(r));
                cnt++;
            }

            return $"Done, listing {cnt} content items";
        }
    }
}
