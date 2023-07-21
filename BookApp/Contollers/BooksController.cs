using BookApp.Interface;
using BookApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookApp.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBook _book;
        public BooksController(IBook book)
        { 
            _book = book;
        }
        [HttpPost("create")]
        public ActionResult<BookOutput> CreateBook([FromBody] BookInput bookInput)
        {
            BookOutput bookOutput = _book.CreateBook(bookInput);
            if (bookOutput == null)
            {
                return BadRequest("Не удалось добавить книгу");
            }
            return Ok(bookOutput);
        }
    }
}
