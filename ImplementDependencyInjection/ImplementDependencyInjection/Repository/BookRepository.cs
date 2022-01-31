using ImplementDependencyInjection.Data;
using ImplementDependencyInjection.Model;
using Microsoft.EntityFrameworkCore;

namespace ImplementDependencyInjection.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly MyBookDbContext _context;

        public BookRepository(MyBookDbContext context)
        {
            _context = context;
        }
        public async Task<List<BookModel>> GetAllBooks()
        {
            var books = await _context.Books.Select(x => new BookModel()
            {
                Id = x.Id,
                Name = x.Name,
            }).ToListAsync();
            return books;
        }
    }
}
