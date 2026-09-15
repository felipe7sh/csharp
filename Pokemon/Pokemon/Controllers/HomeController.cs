using Microsoft.AspNetCore.Mvc;
using Pokemon.Models;
using System.Diagnostics;

namespace Pokemon.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Equipe()
        {
            return View();
        }

    }
}
