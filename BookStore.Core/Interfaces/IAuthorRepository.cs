using BookStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Interfaces
{
  public interface IAuthorRepository
  {
    void AddAuthor(Author author);
    void EditAuthor(Author author);
    void RemoveAuthor(int Id);
    IEnumerable<Author> GetAuthors();
    Author FindAuthorById(int Id);
  }
}
