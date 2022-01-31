using ImplementDependencyInjection.Model;

namespace ImplementDependencyInjection.Repository
{
    public interface IBookRepository
    {
        Task<List<BookModel>> GetAllBooks();
    }
}
