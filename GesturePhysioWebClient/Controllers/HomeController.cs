
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GesturePhysioWebClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Control Panel";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Patient Progress Details.";

            return View();

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us.";

            return View();
        }
    }
}
