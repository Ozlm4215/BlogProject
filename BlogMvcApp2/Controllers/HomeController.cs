using BlogMvcApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMvcApp2.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        public ActionResult Index()
        {
            return View(context.Blogs.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}