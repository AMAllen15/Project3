using System.ComponentModel.DataAnnotations;

namespace Project3.Models
{
    public class Book
    {
        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Author is required")]
        public string? Author { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        public string? Genre { get; set; }

        public int PublishedYear { get; set; }

        public bool IsAvailable { get; set; }
        public ICollection<Borrowing> Borrowings { get; set; }

        public Book()
        {
            Title = null;
            Author = null;
            Genre = null;
        }
    }
}