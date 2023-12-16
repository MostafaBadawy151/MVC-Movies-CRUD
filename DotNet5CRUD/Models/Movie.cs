using System.ComponentModel.DataAnnotations;

namespace DotNet5CRUD.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required, MaxLength(250)]
        public string Title { get; set; }
        public int Year { get; set; }

        public double Rate { get; set; }
        [Required, MaxLength(2500)]
        public string Storeline { get; set; }
        [Required]
        public byte[] Poster { get; set; }

        public byte GenreId { get; set; } // Navigational Property
        public Genre Genre {get; set; } // FK

    }
}
