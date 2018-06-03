using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly1.Models;
using vidly1.ViewModels;

namespace vidly1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
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

        public ActionResult Edit(int id)
        {
            return Content("id= " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            

                pageIndex = 1;
            

            if (String.IsNullOrWhiteSpace(sortBy))
            

                sortBy = "Name";
                return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
            
        }
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {

            return Content(year + "/" + month);
        }
    }
}