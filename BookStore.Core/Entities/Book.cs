using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Core.Entities
{
  public class Book
  {
    public Book()
    {

    }

    [Key]
    public int Book_Id { get; set; }

    [Required]
    [Display(Name = "Book Title")]
    public string Book_Title { get; set; }
    [DataType("decimal(16 ,3")]
    [Display(Name = "Price")]
    public decimal Price { get; set; }

    [Display(Name = "Edition")]
    public string Edition { get; set; }

    [Display(Name = "Author")]
    [ForeignKey("Author")]
    public int Author_Id { get; set; }
    public Author Author { get; set; }
  }
}
