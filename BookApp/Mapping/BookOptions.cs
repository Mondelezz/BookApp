using AutoMapper;
using BookApp.Models;

namespace BookApp.Mapping
{
    public class BookOptions : Profile
    {
        public BookOptions()
        {
            CreateMap<Book, BookInput>();
            CreateMap<BookInput, Book>();
            CreateMap<BookOutput, Book>();
        }
    }
}
