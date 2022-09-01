﻿using CodeArt.Optimizely.DeveloperConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeArt.Optimizely.DeveloperConsole.Interfaces
{
    public interface ILogAwareCommand
    {
        List<CommandLog> Log { get; set; }
    }
}
