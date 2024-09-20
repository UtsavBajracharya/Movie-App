using System.ComponentModel.DataAnnotations;

namespace week3MVCMovie.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }

        [Required(ErrorMessage = "The Phone Number is required.")]
        [RegularExpression(@"^\+?[1-9]\d{1,14}$", ErrorMessage = "The Phone Number is invalid.")]
        public string Phone { get; set; }


        public ICollection<Movie>? Movies { get; set; }

    }
}
