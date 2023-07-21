namespace BookApp.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public ICollection<AuthorBook> AuthorBook { get; set;} = new List<AuthorBook>();
    }
}
