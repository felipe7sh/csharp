using Microsoft.AspNetCore.Mvc;

namespace harry_poter.Controllers
{
    public class PocoesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
