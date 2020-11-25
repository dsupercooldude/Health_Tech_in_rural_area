using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SPAComplexObjectGetter.Models;

namespace SPA_POSTingObjectToServer.Controllers
{
    public class DataController : Controller
    {
        static bool evenRequest = true;

        // url=/data/changecinemadata
        public ActionResult ChangeCinemaData(Cinema cinema)
        {
            evenRequest = !evenRequest;

            // report error on every even request
            if (evenRequest)
            {
                Response.StatusCode = (int)System.Net.HttpStatusCode.InternalServerError;

                return Json("serverError");
            }

            // add movie "Anne of Planet Mars"
            // to Cinema data coming from the client 
            // and return the modified Cinema data
            // back to the client
            cinema.Movies.Add
            (
                new Movie
                {
                    Title = "Anne of Planet Mars",
                    Year = 3000
                }
            );

            return Json(cinema);
        }

    }
}
