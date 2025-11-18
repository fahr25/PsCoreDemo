using Microsoft.AspNetCore.Mvc;
using PsCoreDemo.Repository;

namespace PsCoreDemo.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult List()
        {
            var books = _bookRepository.GetAllBooks();
            if (books == null || !books.Any())
            {
                // Optionally, show a "No books found" view or message
                ViewBag.Message = "No books available.";
            }
            return View(books);
        }

    }
}
