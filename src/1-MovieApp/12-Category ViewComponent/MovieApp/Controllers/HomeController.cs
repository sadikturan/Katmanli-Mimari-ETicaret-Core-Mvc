using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // ProductRepository.Movies 
            // CategoryRepository.Categories

            // MovieCategoryModel model = new MovieCategoryModel();
            // model.Categories = CategoryRepository.Categories;
            // model.Movies = MovieRepository.Movies;

            return View(MovieRepository.Movies);
        }

        public IActionResult Details(int id)
        {
            // MovieCategoryModel model = new MovieCategoryModel();
            // model.Categories = CategoryRepository.Categories;
            // model.Movie = MovieRepository.GetById(id);

            return View(MovieRepository.GetById(id));
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}