using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Microsoft.AspNetCore.Http;
using GetHTMLCodeAndImgsFromWebPage.Models;
using System.Text.RegularExpressions;
using System.Drawing.Imaging;
using System.Drawing;
using Microsoft.EntityFrameworkCore;

namespace GetHTMLCodeAndImgsFromWebPage.Contorllers
{

    public class HomeController : Controller
    {

        private static LinkDbContext _context = new LinkDbContext();
        private readonly Link _link = new Link();
        public HomeController(Link link, LinkDbContext context)
        {
            _context = context;
            _link = link;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult GetUserInput(string linkUrl)
        {

            _link.LinkURL = linkUrl;
            
            _link.GetHTMLCodeFromLink(linkUrl);
            AddToDb(linkUrl);
            

            if (_link.correctUrl == false)
            {
                return View("../Result/ResultIndex");
            }
            else
            {
                return View("../Result/Done");
            }
        }

        private static void AddToDb(string url)
        {
            _context.Add(new Link { LinkURL = url });
            _context.SaveChanges();
        }

    }
}
