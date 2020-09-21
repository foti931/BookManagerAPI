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
        public DbSet<User> Users { get; set; }
        public DbSet<OwnedBookInfo> OwnedBookInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>()
                .HasData(
                    new Book
                    {
                        Id = 1,
                        JanCode1 = "1234567890123",
                        JanCode2 = "1234567890123",
                        IsbnCode = "987-4-12354-123",
                        Title = "テスト本１",
                        InsTime = DateTime.Now,
                        UpdTime = DateTime.Now
                    },
                     new Book
                     {
                         Id = 2,
                         JanCode1 = "2345678901234",
                         JanCode2 = "2345678901234",
                         IsbnCode = "986-4-12354-123",
                         Title = "テスト本２",
                         InsTime = DateTime.Now,
                         UpdTime = DateTime.Now
                     }
            );
            builder.Entity<User>()
                .HasData(
                     new User
                     {
                         Id = 1,
                         FirstName = "たくや",
                         LastName = "たなか",
                         UserName = "TAKUYA",
                         UserPass = "TEST",
                         InsTime = DateTime.Now,
                         UpdTime = DateTime.Now
                     },
                      new User
                      {
                          Id = 2,
                          FirstName = "ころ",
                          LastName = "ころ",
                          UserName = "koro",
                          UserPass = "koro",
                          InsTime = DateTime.Now,
                          UpdTime = DateTime.Now
                      }
            );
            builder.Entity<OwnedBookInfo>()
                 .HasData(
                      new OwnedBookInfo
                      {
                          Id = 1,
                          BookId = 1,
                          UserId = 1,
                          InsTime = DateTime.Now,
                          UpdTime = DateTime.Now
                      }
                );
        }
    }
}
