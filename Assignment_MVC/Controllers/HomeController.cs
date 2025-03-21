using Microsoft.AspNetCore.Mvc;

namespace Assignment_MVC.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return Content( "Hello From Index Action");

        //}

        //public ActionResult AboutUs()
        //{
        //    return Redirect("https://github.com/sherouk22/Assignment_MVC/tree/Assignment02_MVC");


        //}

        public IActionResult Index()
        {
            return View();

        }

        public IActionResult AboutUs()
        {
            return View();

        }

        public IActionResult ContactUs()
        {
            return View();

        }

        public IActionResult Privacy()
        {
            return View();

        }

    }
}
