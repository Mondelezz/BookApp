using System.ComponentModel.DataAnnotations;

namespace BookApp.Models
{
    public class BookOutput
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime DateTime { get; set; }
        public ICollection<AuthorOutput> Authors { get; set; } = new List<AuthorOutput>();
        public ICollection<ReviewOutput> Reviews { get; set; } = new List<ReviewOutput>();
        public ICollection<TagOutput> Tags { get; set; } = new List<TagOutput>();
        public PriceOfferOutput Promotion { get; set; }
    }
}
