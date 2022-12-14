using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeArt.Optimizely.DeveloperConsole.Attributes
{
    public class CommandAttribute : Attribute
    {
        public string Keyword { get; set; }

        public string Group { get; set; }

        public string Syntax { get; set; }

        public string Description { get; set; }

        public CommandAttribute(string Keyword)
        {
            this.Keyword = Keyword;
        }

        public CommandAttribute()
        {

        }

    }
}