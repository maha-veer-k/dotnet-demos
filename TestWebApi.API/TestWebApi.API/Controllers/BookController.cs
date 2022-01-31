using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestWebApi.API.Model;
using TestWebApi.API.Repository;

namespace TestWebApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetBooks()
        {
            var books = await _bookRepository.GetAllBooks();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById([FromRoute] int id)
        {
            var book = await _bookRepository.GetBookById(id);
            if(book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost("")]
        public async Task<IActionResult> AddNewBook([FromBody] BookModel bookModel)
        {
            var bookId = await _bookRepository.AddBook(bookModel);
            return CreatedAtAction("GetBookById", new { id = bookId, Controller = "Book" }, bookId);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook([FromRoute] int id, [FromBody] BookModel bookModel)
        {
            var IsUpdated = await _bookRepository.UpdateBook(id, bookModel);
            if (!IsUpdated)
            {
                return BadRequest();
            }
            return Ok("Updated");
        } 

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook([FromRoute] int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var book = await _bookRepository.DeleteBook(id);
            return Ok($"Book with Id : {book} Deleted successfully");
        }
    }
}
