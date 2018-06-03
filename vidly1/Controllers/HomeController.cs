using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly1.Models;
using vidly1.ViewModels;

namespace vidly1.Controllers
{
    public class HomeController : Controller
    {
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

            var viewModel = new RandomMovieViewModel
            {

                Customers = customers
            };




            return View(viewModel);
        }

        public ActionResult Movies()
        {
            var movies = new List<Movies>
            {
                new Movies {Name="Shrek", Id=1},
                new Movies {Name="Titanic", Id=2}

            };

            var viewModel = new RandomMovieViewModel
            {

                Movies = movies
                
            };

            return View(viewModel);
        }
    }
}