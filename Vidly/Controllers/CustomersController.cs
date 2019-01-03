using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        //List<Customer> customers = new List<Customer>
        //    {
        //        new Customer {Id=1, Name="Raja Mouli"},
        //        new Customer {Id=2, Name="Shankar"},
        //        new Customer {Id=3, Name="Surendhar Reddy"},
        //        new Customer {Id=4, Name="Ram Charan"}
        //    };
        public ActionResult Index()
        {
            //customers = new List<Customer>
            //{
            //    new Customer {Id=1, Name="Raja Mouli"},
            //    new Customer {Id=2, Name="Shankar"},
            //    new Customer {Id=3, Name="Surendhar Reddy"},
            //    new Customer {Id=4, Name="Ram Charan"}
            //};

            //var customers = GetCustomers();
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            //Customer customer = customers.Where(x=>x.Id==id).FirstOrDefault();
            //return View(customer);
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        //private IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //    {
        //        new Customer {Id=1, Name="Raja Mouli"},
        //        new Customer {Id=2, Name="Shankar"},
        //        new Customer {Id=3, Name="Surendhar Reddy"},
        //        new Customer {Id=4, Name="Ram Charan"}
        //    }; 
        //}
    }
}