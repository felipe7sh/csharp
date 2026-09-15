using Microsoft.AspNetCore.Mvc;

namespace LojaMusica.Controllers
{
    public class CordasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
