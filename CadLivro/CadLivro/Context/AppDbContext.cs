using CadLivro.Models;
using Microsoft.EntityFrameworkCore;

namespace CadLivro.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Livro> Livros { get; set; }
    }
}