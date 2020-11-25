using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPAComplexObjectGetter.Models
{
    public class Cinema
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Movie> Movies { get; set; }

        // empty default constructor
        // (we get the data from the client so
        //  no need to mock data on the server)
        public Cinema()
        {
        }
    }
}