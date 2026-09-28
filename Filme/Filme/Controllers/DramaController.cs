using Microsoft.AspNetCore.Mvc;

namespace Filme.Controllers
{
    public class DramaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
