using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using GetHTMLCodeAndImgsFromWebPage.Models;

namespace GetHTMLCodeAndImgsFromWebPage.Contorllers
{
    public class ResultController : Controller
    {
        
        public IActionResult ResultIndex()
        {
            return View();
        }

        public ActionResult GoBack()
        {
            return View("../Home/Index");
        }
    }
}
