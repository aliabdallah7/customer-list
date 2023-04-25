using customer_list.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace customer_list.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

        // GET: Customers/Display
        public ActionResult Display()
        {
            List<Customer> customers = db.customers.ToList();
            return View(customers);
        }
    }
}