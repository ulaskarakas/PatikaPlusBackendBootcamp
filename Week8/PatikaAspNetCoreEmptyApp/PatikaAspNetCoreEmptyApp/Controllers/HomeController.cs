using Microsoft.AspNetCore.Mvc;

namespace PatikaAspNetCoreEmptyApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}