using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly1.Models;
using vidly1.ViewModels;

namespace vidly1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Customers()
        {

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1", Id=1},
                new Customer {Name="Customer 2", Id=2}
            };

            var viewModel = new MovieCustomerViewModel()
            {

                Customers = customers
            };




            return View(viewModel);
        }

        [Route("Customer/Details/{customerId}")]
    public ActionResult Details(int customerId)
        {

            
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1", Id=1},
                new Customer {Name="Customer 2", Id=2}
            };

            var viewModel = new MovieCustomerViewModel()
            {

                Customers = customers
            };

            return View(viewModel);
        }

    }
}