
using ClienteAtividade.Context;
using ClienteAtividade.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClienteAtividade.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var clientes = _context.Clientes.ToList();

            return View(clientes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Clientes.Add(cliente);

                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(cliente);
        }
    }
}
