using Microsoft.AspNetCore.Mvc;

namespace RecruiterPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
