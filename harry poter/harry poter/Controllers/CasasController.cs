using Microsoft.AspNetCore.Mvc;

namespace harry_poter.Controllers
{
    public class CasasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
