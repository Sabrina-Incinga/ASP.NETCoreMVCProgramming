using Microsoft.AspNetCore.Mvc;
using System;

namespace MVCEmpleado.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Saludo = "Bienvenidos!";
            ViewBag.Fecha = DateTime.Now.ToString();
            return View();
        }
    }
}
