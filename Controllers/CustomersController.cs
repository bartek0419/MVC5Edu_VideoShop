using System.Collections;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using VideoShop.Models;
using VideoShop.ViewModels;

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
            var customers = _context.Customers.Include(c=>c.MembershipType).ToList();

            return View(customers);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _context.Dispose();
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).ToList().Single(c => c.Id == id);
            return View(customer);
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var customerViewModel = new CustomerViewModel
            {
                MembershipTypes = membershipTypes,
                Customer =new Customer()
            };
            return View(customerViewModel);
        }

        public ActionResult Create()
        {
            throw new System.NotImplementedException();
        }
    }
}