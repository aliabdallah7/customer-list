using customer_list.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace customer_list.Controllers
{
    public class customersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }

        // GET: customers/Display
        public ActionResult Display()
        {
            List<Customer> customers = db.customer.ToList();
            return View(customers);
        }
    }
}