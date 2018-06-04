using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly1.Models;

namespace vidly1.ViewModels
{
    public class MovieCustomerViewModel
    {
       
        public List<Movies> Movies { get; set; }

        public List<Customer> Customers { get; set; }
    }
}