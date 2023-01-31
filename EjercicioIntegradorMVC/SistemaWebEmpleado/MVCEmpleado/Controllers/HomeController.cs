using Microsoft.AspNetCore.Mvc;

namespace MVCEmpleado.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
