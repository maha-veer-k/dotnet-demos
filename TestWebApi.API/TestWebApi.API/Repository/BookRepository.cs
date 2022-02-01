using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using TestWebApi.API.Data;
using TestWebApi.API.Model;

namespace TestWebApi.API.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDbContext _context;
        private readonly IMapper _mapper;

        public BookRepository(BookDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<BookModel>> GetAllBooks()
        {
            //var books = await _context.Books.Select(x => new BookModel()
            //{
            //    Id = x.Id,
            //    Name = x.Name,
            //}).ToListAsync();
            //return books;

            var books = await _context.Books.ToListAsync(); 
            return _mapper.Map<List<BookModel>>(books);
        }

        public async Task<BookModel> GetBookById(int bookId)
        {
            //var book = await _context.Books.Where(x => x.Id == bookId).Select(x => new BookModel()
            //{
            //    Id = x.Id,
            //    Name = x.Name,
            //}).FirstOrDefaultAsync();
            //return book;

            var book = await _context.Books.FindAsync(bookId);
            return _mapper.Map<BookModel>(book);

        }

        public async Task<int> AddBook(BookModel bookModel)
        {
            var book = new Books()
            {
                Id = bookModel.Id,
                Name = bookModel.Name,
            };
             _context.Books.Add(book);
             await _context.SaveChangesAsync();
             return book.Id;
        }

        public async Task<bool> UpdateBook(int bookId, BookModel bookModel)
        {
            var book = new Books()
            {
                Id = bookId,
                Name = bookModel.Name
            };

            if(book.Id == 0)
            {
                return false;
            }
           
            await _context.SaveChangesAsync();
            return true;
        }
        
        public async Task<bool> UpdateBookPatch(int bookId, JsonPatchDocument bookModel)
        {
            var book = await _context.Books.FindAsync(bookId);
            if(book != null)
            {
                bookModel.ApplyTo(book);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<int> DeleteBook(int bookId)
        {
            var book = new Books() { Id = bookId };
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return bookId;
        }
    }
}
