using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            //Custom Route
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    new { Controller = "Movies", Action = "ByReleaseDate" });

            //Custom Route With Constraints (The below route will accepts only Year with 4 digits and month wiht 2 digits)
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    new { Controller = "Movies", Action = "ByReleaseDate" },
            //    new { year = @"\d{4}", month = @"\d{2}" });

            //Custom Route With Constraints (The below route will accepts only Year as 2015 or 2016)
            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //    new { Controller = "Movies", Action = "ByReleaseDate" },
            //    new { year = @"2015|2016", month = @"\d{2}" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Customers", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
