using Microsoft.AspNetCore.Mvc;

namespace TopSolutions.WebApi.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
