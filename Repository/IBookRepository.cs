using PsCoreDemo.Models;

namespace PsCoreDemo.Repository
{
    /// <summary>
    /// Repository interface for managing Book entities
    /// </summary>
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();

        /// <summary>
        /// Retrieves a book by its unique identifier
        /// </summary>
        /// <returns>The Book entity if found; otherwise, null</returns>
        Book GetBookById(int bookId);
    }
}