using System.ComponentModel.DataAnnotations;

namespace Project3.Models
{
    public class Reader
    {
        public Reader()
        {
            Name = "";
            Email = "";
            Address = "";
            ContactNumber = "";
        }

        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "ContactNumber is required")]
        public string ContactNumber { get; set; }

        public ICollection<Borrowing> Borrowings { get; set; }
    }
}