using Microsoft.EntityFrameworkCore;
using revisao.Models;

namespace revisao.Context 
{ 

	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
		public DbSet<Produto> Produtos { get; set; }
	}
}