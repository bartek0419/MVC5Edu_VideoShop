using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoShop.Dtos;
using VideoShop.Models;

namespace VideoShop.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Movies

        public ActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.ToList().Single(m => m.Id == id);
            return View(movie);
        }

        public ActionResult NewMovie()
        {
            var movieFormDto = new MovieFormDto
            {
                Title = "New Movie",
                Movie = new Movie()
            };
            return View("MovieForm",movieFormDto);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.DateAdded = movie.DateAdded;
                movieInDb.Genre= movie.Genre;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.StockNumber= movie.StockNumber;
            }

            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
                throw;
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var moviesInDb = _context.Movies.Single(m => m.Id == id);
            var movieFormDto = new MovieFormDto()
            {
                Title = "Edit Movie",
                Movie = moviesInDb
            };
            return View("MovieForm", movieFormDto);
        }
    }
}