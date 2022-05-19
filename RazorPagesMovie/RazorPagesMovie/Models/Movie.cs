using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; } //required by the database for the primary key.
        public string Title { get; set; } = string.Empty;

        //With this attribute:
        //- The user isn't required to enter time information in the date field.
        //- Only the date is displayed, not time information.

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
