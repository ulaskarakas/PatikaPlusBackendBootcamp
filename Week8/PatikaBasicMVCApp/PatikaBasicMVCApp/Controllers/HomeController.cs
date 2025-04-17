using Microsoft.AspNetCore.Mvc;

namespace PatikaBasicMVCApp.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

    }
}
