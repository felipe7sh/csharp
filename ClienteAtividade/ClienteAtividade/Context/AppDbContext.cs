using ClienteAtividade.Models;
using Microsoft.EntityFrameworkCore;

namespace ClienteAtividade.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
