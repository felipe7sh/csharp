using Microsoft.AspNetCore.Mvc;

namespace Pokemon.Controllers
{
    public class AguaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
