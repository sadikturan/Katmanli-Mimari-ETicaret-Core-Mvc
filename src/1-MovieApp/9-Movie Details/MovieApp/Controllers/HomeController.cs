using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Movies);
        }

        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}