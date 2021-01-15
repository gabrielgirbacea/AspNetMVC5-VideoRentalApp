using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        [Route]
        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>() {
                new Customer{ Id=1, Name="Cusomter 1" },
                new Customer{ Id=2, Name="Cusomter 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }


        public ActionResult Edit(int movieId)
        {
            return Content("id=" + movieId);
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year}/{month}");
        }

        private List<Movie> GetMovies()
        {
            return new List<Movie>() {
                new Movie() { Id = 0, Name = "Shrek" },
                new Movie() { Id = 1, Name = "Shrek 2" },
                new Movie() { Id = 2, Name = "Shrek 3" }
            };
        }

    }

}