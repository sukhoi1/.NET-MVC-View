using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Views/Shared/One.cshtml", (object)"demo");
        }
        public ActionResult Many()
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("Placeholder Property", "Placeholder Value");
            return View("~/Views/Shared/Many.cshtml", (object)data);
        }

        public ActionResult Inline()
        {
            return View();
        }

        public ActionResult Layout()
        {
            return View();
        }

        public ActionResult Section()
        {
            return View();
        }

        public ActionResult SectionOptional()
        {
            return View();
        }

        public ActionResult Partial()
        {
            return View();
        }

        public ActionResult ViewNoModel()
        {
            return View(new DateTime().Date);
        }

        public ActionResult ChildAction()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult ChildActionAttribute()
        {
            return View();
        }
    }
}