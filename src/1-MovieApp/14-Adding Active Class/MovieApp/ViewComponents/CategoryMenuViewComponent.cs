using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;

namespace MovieApp.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // home/index/3
            // {controller}/{action}/{id?}
            // RouteData.Values["controller"] => home
            // RouteData.Values["action"] => index
            // RouteData.Values["id"] => 3

            if (RouteData.Values["action"].ToString() == "Index")
                ViewBag.SelectedCategory = RouteData?.Values["id"];

            return View(CategoryRepository.Categories);
        }
    }
}