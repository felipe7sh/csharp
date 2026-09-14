using Atividade13.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Atividade13.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Seguranca()
        {
            return View();
        }
    }
}
