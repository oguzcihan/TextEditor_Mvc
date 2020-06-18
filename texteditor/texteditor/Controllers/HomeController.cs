using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using texteditor.Models;

namespace texteditor.Controllers
{
    public class HomeController : Controller
    {
        private EgitimContext context = new EgitimContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(context.Bloglar.ToList());
        }
    }
}