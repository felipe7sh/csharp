
using CadLivro.Context;
using CadLivro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CadLivro.Controllers
{
    public class LivrosController : Controller
    {
        private readonly AppDbContext _context;

        // Injeção do AppDbContext pelo construtor
        public LivrosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Livros
        public IActionResult Index()
        {
            var livros = _context.Livros.ToList();

            return View(livros);
        }

        // GET: Livros/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Livros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Livro livro)
        {
            if (ModelState.IsValid)
            {
                _context.Livros.Add(livro);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(livro);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
