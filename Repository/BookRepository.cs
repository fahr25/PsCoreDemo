using PsCoreDemo.Models;
using PsCoreDemo.Data;

namespace PsCoreDemo.Repository
{
    /// <summary>
    /// Repository implementation for managing Book entities
    /// </summary>
    public class BookRepository : IBookRepository
    {
        private readonly MarketShopDbContext _context;

        public BookRepository(MarketShopDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        /// <summary>
        /// Retrieves a book by its unique identifier
        /// </summary>
        /// <returns>The Book entity if found; otherwise, null</returns>
        public Book GetBookById(int bookId)
        {
            Book? bookToGet = _context.Books.FirstOrDefault(b => b.Id == bookId);
            
            if (bookToGet == null)
            {
                throw new ArgumentException($"Book with ID {bookId} not found.");
            } 

            return bookToGet;
            
        }
    }
}