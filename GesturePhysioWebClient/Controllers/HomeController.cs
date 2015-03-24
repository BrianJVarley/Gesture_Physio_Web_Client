
using GesturePhysioWebClient.Models;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
//using Microsoft.WindowsAzure.MobileServices;

namespace GesturePhysioWebClient.Controllers
{
    

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Control Panel";

            return View();
        }

        //used to restrict non logged in users from accessing the 
        //patient records, planning to modify so only cetain roles
        //can view records, eg ADMIN
        [Authorize]
        public async Task<ActionResult> About()
        {
            var mobileClient = new MobileServiceClient("https://progressreportdb.azure-mobile.net/",
                "yZdIWPDVuQQruDylqLZCVXvKsKRsKD40"
            );
            var itemModelTable = mobileClient.GetTable<Item>();

            var result = await itemModelTable.ToListAsync();

            ViewBag.Message = "Patient Progress Details.";

            return View(result);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us.";

            return View();
        }
    }
}
