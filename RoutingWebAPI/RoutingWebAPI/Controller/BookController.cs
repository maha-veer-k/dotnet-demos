using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoutingWebAPI.Models;

namespace RoutingWebAPI.Controller
{
    //[Route("api/[controller]")]
    [ApiController]
    [Route("[controller]/[action]")]
    public class BookController : ControllerBase
    {
        private List<Book> books;
        public BookController()
        {
            books = new List<Book>()
            {
                new Book() {Id = 1, Name = "Mahaveer"},
                new Book() {Id = 2, Name = "Sharma"}
            };
        }

        [Route("", Name = "All")]
        public IActionResult GetBooks()
        {
            return Ok(books);
        }

        [Route("{id}")]
        public IActionResult GetBookById(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            return Ok(books[id-1]);
        }

        [Route("~/api/accept/{id}")]
        public IActionResult BookAccept(int id)
        {
            if(id == 0) { return NotFound(); }
            if(id == 1) { return Accepted(); }
            if(id == 2) { return Accepted("~/Book/GetBooks"); }
            if(id == 3) { return AcceptedAtAction("GetBooks"); }
            if(id == 4) { return AcceptedAtRoute("All"); }
            return BadRequest();
        }

        [Route("{id}")]
        public IActionResult Add(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            return Ok(books.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost("")]
        public IActionResult CreateBook(Book book)
        {
            books.Add(book);
            //return Created("~/Book/Add"+book.Id,book);
            return CreatedAtAction("Add", new { id = book.Id }, book);
        }

        [Route("~/redirect")]
        public IActionResult Redirection()
        {
            return LocalRedirect("~/Book/GetBooks");
        }
    }
}
