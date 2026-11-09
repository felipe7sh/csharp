
using CadLivro.Context;
using CadLivro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CadLivro.Controllers
{
    public class LivrosController : Controller
    {
        private readonly AppDbContext _context;

        public LivrosController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var livros = _context.Livros.ToList();

            return View(livros);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
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
    }
}
