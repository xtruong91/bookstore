using BookStore.Core.Entities;
using System.Data.Entity;

namespace BookStore.Infrastructure
{
  public class BookStoreContext : DbContext
  {
    public BookStoreContext() : base("name=libraryappconnectionstring")
    {

    }
    public DbSet<Book> Books { get; set; }
    //protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Book>().Property(x => x.Price).HasPrecision(16, 3);
    //}
    public DbSet<Author> Authors { get; set; }
  }
}
