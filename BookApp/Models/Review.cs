using System.ComponentModel.DataAnnotations;

namespace BookApp.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int NumStars { get; set; }
        [MaxLength(1000)]
        public string Comment { get; set; }
        public int BookId { get; set; }

    }
}
