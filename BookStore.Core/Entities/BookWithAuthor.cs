﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Core.Entities
{
  public class BookWithAuthor
  {
    public int BookWithAuthor_Id { get; set; }
    public string BookWithAuthor_Title { get; set; }
    public string BookWithAuthor_AuthorName { get; set; }
    public decimal Price { get; set; }
    public string Edition { get; set; }
  }
}
