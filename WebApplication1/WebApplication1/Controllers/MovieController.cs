using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }
        [Route("movie/release/{year:range(1995, 2017)}/{month:range(1, 12)}")]
        public ActionResult ReleaseDate(int year, int month) {
            return Content("Year = " + year + " Month = " + month);
            //return Json(new { Name = "ahmed", Age = "12" }, JsonRequestBehavior.AllowGet);
            //return RedirectToAction("Index", "Home", new { PageIndex = "12", Name = "Ahmed" });
            //return View();
        }
        public ActionResult Random()
        {
            List<Customer> customers = new List<Customer> {
                new Customer { Id = 1 ,Name = "Ahmed" },
                new Customer { Id = 5 ,Name = "Mohamed" },
                new Customer { Id = 8 ,Name = "Ali" },
            };
            Movie movie = new Movie { Id = 45, Name = "Avangers" };
            MovieCustomerModel mcm = new MovieCustomerModel
            {
                Customers = customers,
                Movie = movie,
            };
            //ViewData["Movie"] = movie;
            return View(mcm);
        }
    }
}