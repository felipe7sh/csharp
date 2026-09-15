using LojaMusica.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LojaMusica.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Teclas()
        {
            return View();
        }

        public IActionResult Cordas()
        {
            return View();
        }
    }
}
