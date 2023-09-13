using BookstoreAPP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ShoppingCartSystem.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
		{ 

		}

		public DbSet<Book> Books { get; set; }
		public DbSet<Order> Orders { get; set; }
		//public DbSet<Inventory> Inventory { get; set; }

	}
}
