using Microsoft.AspNetCore.Mvc;

namespace Filme.Controllers
{
    public class AcaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
