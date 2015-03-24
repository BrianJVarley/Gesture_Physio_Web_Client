using GesturePhysioWebClient.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GesturePhysioWebClient.Controllers
{
    public class PatientController : Controller
    {
        //
        // GET: /Patient/

        public ActionResult DetailsPage()
        {
            using (var db = new PatientContext())
            {
                return View(db.Items.Count());
            }
        }

    }
}
