namespace BookApp.Models
{
    public class AuthorBook
    {
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
    }
}
