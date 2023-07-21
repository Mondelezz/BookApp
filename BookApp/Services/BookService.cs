using AutoMapper;
using BookApp.Data;
using BookApp.Interface;
using BookApp.Models;

namespace BookApp.Services
{
    public class BookService : IBook
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public BookService(DataContext dataContext, IMapper mapper) 
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public BookOutput CreateBook(BookInput bookInput)
        {       
            Book book = _mapper.Map<Book>(bookInput);
            if (book != null)
            {
                book.DateTime = DateTime.UtcNow;
                _dataContext.Books.Add(book);
                _dataContext.SaveChanges();
                Console.WriteLine("Добавленная книга:" + book);
            }
            else
            {
                throw new Exception("Данные не найдены");
            }
            BookOutput bookOutput = _mapper.Map<BookOutput>(book);              
            return bookOutput;
        }
    }
}
