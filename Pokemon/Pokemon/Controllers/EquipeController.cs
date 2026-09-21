using Microsoft.AspNetCore.Mvc;

namespace Pokemon.Controllers
{
    public class EquipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
