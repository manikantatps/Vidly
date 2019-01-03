using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie { Name = "Shrek!" };
            //return View(movie);
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { Page = 1 });

            //ViewData
            //ViewData["Movie"] = movie;

            //ViewBag
            //ViewBag.Movie = movie;
            //return View();

            var customers = new List<Customer>
            {
                new Customer { Name="Customer 1"},
                new Customer { Name="Customer 2"},
                new Customer { Name="Customer 3"},
                new Customer { Name="Customer 4"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("Id=" + id);
        }

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("PageIndex={0}&SortBy={1}", pageIndex, sortBy));
        //}

        //Attribute Routing
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        //Excerse - Section -2

        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie { Name="Bahubali"},
                new Movie { Name="Robo"},
                new Movie { Name="Syee Ra"},
                new Movie { Name="Dhruva"}
            };
            
            //var viewModel = new RandomMovieViewModel
            //{
            //    Movie = movie,
            //    Customers = customers
            //};

            return View(movies);
        }
    }
}