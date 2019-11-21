using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public Genre Genre { get; set; }
        [Required]
        [Range(1, 10, ErrorMessage = "Rating should be between 1 and 10")]
        public decimal Rating { get; set; }
    }
}
