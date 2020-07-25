using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>().
                HasData(
                    new Book { Id = 1, Title = "First" },
                    new Book { Id = 2, Title = "Second" },
                    new Book { Id = 3, Title = "Third" }
                );
        }
    }
}
