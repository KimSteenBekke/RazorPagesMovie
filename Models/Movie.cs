using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Artist { get; set; } = string.Empty;

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; } = string.Empty;

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
       public string Genre { get; set; } = string.Empty;

       [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
       public string Format { get; set; } = string.Empty;

       [StringLength(100, MinimumLength = 3)]
        [Required]
        public string Label { get; set; } = string.Empty;

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string CatNumber { get; set; } = string.Empty;        
    }
}

