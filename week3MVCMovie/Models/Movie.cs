using System.ComponentModel.DataAnnotations;

namespace week3MVCMovie.Models
{
    public class Movie
    {
        [Required(ErrorMessage = "The Movie ID is required.")]

        public int Id { get; set; }
        
        [Required(ErrorMessage = "The Title is required.")]
        [StringLength(100, ErrorMessage = "The Title cannot be longer than 100 character.")]

        public string Title { get; set; }

        [StringLength(1000, ErrorMessage = "The Description cannot be longer than 1000 character.")]
        public string Description { get; set; }

        [Range(1000, 2100, ErrorMessage = "The year must be between 1000 and 2100.")]
        public int Year { get; set; }

        public int AuthorId { get; set; }

        public Author? Author { get; set; }


    }
    
}
