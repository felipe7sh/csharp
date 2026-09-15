using Microsoft.AspNetCore.Mvc;

namespace LojaMusica.Controllers
{
    public class TeclasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
