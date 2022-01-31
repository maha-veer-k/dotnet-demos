using TestWebApi.API.Model;

namespace TestWebApi.API.Repository
{
    public interface IBookRepository
    {

        Task<List<BookModel>> GetAllBooks();
        Task<BookModel> GetBookById(int id);
        Task<int> AddBook(BookModel book);
        Task<bool> UpdateBook(int bookId, BookModel bookModel);
        Task<int> DeleteBook(int bookId);
    }
}
