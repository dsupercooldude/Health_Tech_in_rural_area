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

        public Cinema()
        {
            Name = "Mohawk Mall Cinema";
            Description = "An OK Cinema";

            Movies = new List<Movie>
            {
                new Movie
                {
                    Title = "Anne of Green Gables",
                    Year = 1985
                },
                new Movie 
                {
                    Title = "Anne of Avonlea",
                    Year = 1987
                }
            };
        }
    }
}