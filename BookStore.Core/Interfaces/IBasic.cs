using BookStore.Core.Entities;
using System.Collections.Generic;

namespace BookStore.Core.Interfaces
{
  public interface IBasic
  {
    IEnumerable<Basic> GetAuthorsIdName();

    IEnumerable<Basic> GetEditionIdName();

    IEnumerable<Basic> GetEmplyeeStatusIdName();
  }
}
