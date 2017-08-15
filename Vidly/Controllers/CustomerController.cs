using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;


namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {

            var customers = GetCustomers();
            return View(customers);

        }


        private List<Customer> GetCustomers()
        {
            var cust = new List<Customer>
            {
                new Customer() {Id=1, Name = "John Smith"},
                new Customer() {Id= 2, Name = "Mary Williams"}

            };
            return cust;
        }

        public ActionResult Details(int id)
        {

            Customer item = GetCustomers().First(x => x.Id == id);


            return View(item);
        }

    }
}