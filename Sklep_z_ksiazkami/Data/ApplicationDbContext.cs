using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sklep_z_ksiazkami.Models;

namespace Sklep_z_ksiazkami.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Sklep_z_ksiazkami.Models.Book>? Book { get; set; }
        public DbSet<Sklep_z_ksiazkami.Models.Order>? Order { get; set; }
		public DbSet<Sklep_z_ksiazkami.Models.User>? User { get; set; }
	}
}