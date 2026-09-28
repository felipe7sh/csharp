using Microsoft.AspNetCore.Mvc;

namespace Filme.Controllers
{
    public class SuspenseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
