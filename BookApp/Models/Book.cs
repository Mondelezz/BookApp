using System.ComponentModel.DataAnnotations;

namespace BookApp.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime DateTime { get; set; }
        public ICollection<AuthorBook> AuthorLink { get; set; } = new List<AuthorBook>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Tag> Tags { get; set; } = new List<Tag>();
        public PriceOffer Promotion { get; set; }

    }
}
