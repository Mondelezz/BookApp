using BookApp.Models;

namespace BookApp.Interface
{
    public interface IBook
    {
        public BookOutput CreateBook(BookInput BookInput);        
    }
}
