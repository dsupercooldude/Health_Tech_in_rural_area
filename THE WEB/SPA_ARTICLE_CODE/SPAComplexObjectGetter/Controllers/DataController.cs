using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SPAComplexObjectGetter.Models;

namespace SPAComplexObjectGetter.Controllers
{
    public class DataController : Controller
    {
        public ActionResult GetCinema()
        {
            // create a cinema object populated with data
            Cinema cinema = new Cinema();

            // send it in JSON form back to the client
            return Json(cinema, JsonRequestBehavior.AllowGet);
        }
    }
}
