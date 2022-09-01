using CodeArt.Optimizely.DeveloperConsole.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeArt.Optimizely.DeveloperConsole.Controllers
{


    public class CLIController : Controller
    {
        private readonly CommandManager _manager;



        public CLIController(CommandManager cman)
        {
            _manager = cman;
        }

        public IActionResult FetchLog(int LastLogNo, string session = null)
        {
            if (session == null) session = Guid.NewGuid().ToString();
            var log = _manager.GetLogs(session);
            var lst =log.Skip(LastLogNo).Take(100).ToList();
            return Json(new { LastNo = LastLogNo + lst.Count, LogItems = lst, Session = session });
        }

        [HttpPost]
        public IActionResult RunCommand(string command, string session = null)
        {
            if (session == null) session = Guid.NewGuid().ToString();
            var rf = _manager.ExecuteCommand(command, session);
            if (rf != null)
            {
                string data=Convert.ToBase64String(rf.Data);
                string filename = rf.FileName;
                return Json(new { Success = true, Session = session, Filename = filename, Data = data });
            } else return Json(new { Success = true, Session=session });
        }

        public ActionResult Index()
        {
            return Content("Test");
        }
    }
}
