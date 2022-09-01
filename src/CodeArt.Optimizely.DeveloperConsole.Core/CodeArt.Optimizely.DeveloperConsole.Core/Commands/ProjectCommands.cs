using CodeArt.Optimizely.DeveloperConsole.Interfaces;
using EPiServer;
using EPiServer.DataAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeArt.Optimizely.DeveloperConsole.Commands
{
    public abstract class ProjectCommandBase : IConsoleCommand
    {
        protected readonly ProjectRepository projectRepository;
        protected readonly IContentRepository contentRepository;

        public ProjectCommandBase(ProjectRepository projectRepository, IContentRepository contentRepository)
        {
            this.projectRepository = projectRepository;
            this.contentRepository = contentRepository;
        }

        public abstract string Execute(params string[] parameters);
        
    }

    //https://world.episerver.com/documentation/developer-guides/CMS/projects/creating-a-project-programmatically/

    //List projects, add project, delete project, add items, remove items, list items
    //publish project?
    public class ListProjects : ProjectCommandBase, IOutputCommand
    {
        public event CommandOutput OnCommandOutput;

        public ListProjects(ProjectRepository projectRepository, IContentRepository contentRepository) : base(projectRepository, contentRepository)
        {

        }

        public override string Execute(params string[] parameters)
        {
            return "";
        }
    }
}