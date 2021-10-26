using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public enum Genres
    {
        Action, Comedy, Drama, Fantasy, Horror, Mystery, Romance, Thriller, Western
    }

    public class Movie
    {
        [Key]
        public int ID { get; set; }

        [StringLength(60), Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public Genres Genre { get; set; }

        public decimal Price { get; set; }
    }
}
