using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VideoShop.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie {Name = "Shrek", Id = 1},
                new Movie {Name = "Star War", Id = 2}
            };
            return View();
        }
    }

    public class Movie
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}