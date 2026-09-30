using Microsoft.EntityFrameworkCore;
using G_NET_65_EF001.Entities;

namespace G_NET_65_EF001
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            
            optionsBuilder.UseSqlServer("Server=.;Database=BookStoreDb_EF;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}