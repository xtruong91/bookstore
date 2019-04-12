using BookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infrastructure
{
  public class BookStoreDbInitialize : DropCreateDatabaseIfModelChanges<BookStoreContext>
  {
    protected override void Seed(BookStoreContext context)
    {
      //Author
      context.Authors.Add
      (
            new Author
            {
              Auth_Id = 1,
              First_Name = "Author FirstName 001",
              Last_Name = "Author LastName 001",
              Biography = "Author 1st Bio",
              IsEmployed = "Y"
            }
        );

      context.Authors.Add
      (
           new Author
           {
             Auth_Id = 2,
             First_Name = "Author FirstName 002",
             Last_Name = "Author LastName 002",
             Biography = "Author 2nd Bio",
             IsEmployed = "Y"
           }
      );

      context.Authors.Add
      (
           new Author
           {
             Auth_Id = 3,
             First_Name = "Author FirstName 003",
             Last_Name = "Author LastName 003",
             Biography = "Author 3rd Bio",
             IsEmployed = "N"
           }
      );


      //Book
      context.Books.Add
      (
            new Book
            {
              Book_Id = 1,
              Book_Title = "Book Title 001",
              Edition = "1st Edition",
              Price = 40.0M,
              Author_Id = 1
            }
        );

      context.Books.Add
      (
           new Book
           {
             Book_Id = 2,
             Book_Title = "Book Title 002",
             Edition = "3rd Edition",
             Price = 80.00M,
             Author_Id = 2
           }
      );

      context.Books.Add
      (
           new Book
           {
             Book_Id = 3,
             Book_Title = "Book Title 003",
             Edition = "4th Edition",
             Price = 120.00M,
             Author_Id = 3
           }
      );

      context.SaveChanges();

      base.Seed(context);

    }
  }
}
