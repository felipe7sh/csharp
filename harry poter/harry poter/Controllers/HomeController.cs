using harry_poter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace harry_poter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
