using Microsoft.AspNetCore.Mvc;

namespace Pokemon.Controllers
{
    public class FogoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
