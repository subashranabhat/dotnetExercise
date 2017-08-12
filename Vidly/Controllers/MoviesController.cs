using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;


namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public int Id { get; set; }

        // GET: Movies/Random
        //for RandomMovieViewModel
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "spiderMan" };

            var customers = new List<Customer>
            {
                new Customer() {Name="Customer 1"},
                new Customer() {Name="Customer 2"},
            };

            var viewModel = new RandomMovieViewModel() { Movie = movie, Customers = customers };


            return View(viewModel);
            // return Content("doe sthis work");
            //  return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });


        }



        public ActionResult Edit(int id)
        {

            return Content("id is" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {

            if (pageIndex == null)
            {
                pageIndex = 1;
            }

            if (sortBy == null)
            {
                sortBy = "Name";
            }

            return Content("page Index =" + pageIndex + " sortBy = " + sortBy);

            //return Json(result, JsonRequestBehavior.AllowGet);

        }

        [Route("Movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {

            return Content(year + " " + month);
        }


    }
}