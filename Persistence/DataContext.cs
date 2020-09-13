using Domain;
using Microsoft.EntityFrameworkCore;
using System;

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
                    new Book { Id = "1", Title = "First", JAN = "1", InsTime = DateTime.Now, UpdTime = DateTime.Now },
                    new Book { Id = "2", Title = "Second", JAN = "2", InsTime = DateTime.Now, UpdTime = DateTime.Now },
                    new Book { Id = "3", Title = "Third", JAN = "3", InsTime = DateTime.Now, UpdTime = DateTime.Now }
                ); ;
        }
    }
}
