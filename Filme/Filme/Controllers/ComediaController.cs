using Microsoft.AspNetCore.Mvc;

namespace Filme.Controllers
{
    public class ComediaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
