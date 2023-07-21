using System.ComponentModel.DataAnnotations;

namespace BookApp.Models
{
    public class BookInput
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
