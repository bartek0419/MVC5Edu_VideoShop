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
            var movies = GetMovies();
            return View(movies);
        }

        private static List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Name = "Shrek", Id = 1},
                new Movie {Name = "Star War", Id = 2}
            };
        }
    }

    public class Movie
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}