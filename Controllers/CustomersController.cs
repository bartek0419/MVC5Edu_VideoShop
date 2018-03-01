using System.Linq;
using System.Web.Mvc;
using VideoShop.Models;

namespace VideoShop.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Customers

        public ActionResult Index()
        {
            var customers = _context.Customers.ToList();

            return View(customers);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }
    }
}