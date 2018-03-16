using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
            return View(new Movie());
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}