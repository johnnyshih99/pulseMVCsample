using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PulseTemp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Filter(string tNumber)
        {

            return ViewBag.Message = "jibah";
        }

        public ActionResult GetPartTemp(int id)
        {
            ViewData["temp"] = id;

            return PartialView("_Templates");
        }
    }
}