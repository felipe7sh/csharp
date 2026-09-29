using CadProduto.Models;
using Microsoft.EntityFrameworkCore;

namespace CadProduto.Context
{
    public class AppDbContext : DbContext
    {
        // metodo construtor 
        // e todo metodo com o  mesmo nome na classe ele e executado
        //automaticamente quando a classe e chamada (instanciada)

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Produto> Produtos { get; set; }
    }
}
