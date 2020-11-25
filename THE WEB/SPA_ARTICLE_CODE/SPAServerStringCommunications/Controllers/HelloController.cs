using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPAServerStringCommunications.Controllers
{
    public class HelloController : Controller
    {
        public ActionResult GetHelloMessage(string name)
        {
            // AllowGet flag states that the method can be accessed
            // by GET HTTP request.
            return Json("Hello " + name, JsonRequestBehavior.AllowGet);
        }

    }
}
