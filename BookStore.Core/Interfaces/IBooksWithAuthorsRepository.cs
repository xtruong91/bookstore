using BookStore.Core.Entities;
using System.Collections.Generic;

namespace BookStore.Core.Interfaces
{
  public interface IBooksWithAuthorsRepository
  {
    IEnumerable<BookWithAuthor> GetBooksWithAuthors();
    BookWithAuthor FindBooksWithAuthorsById(int BookWithAuthor_Id);
  }
}
