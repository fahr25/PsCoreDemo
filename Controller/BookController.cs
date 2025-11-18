using Microsoft.AspNetCore.Mvc;
using PsCoreDemo.Repository;
using PsCoreDemo.Models;
using PsCoreDemo.ViewModels;

namespace PsCoreDemo.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult GetAllBooks()
        {
            BookListViewModel bookListViewModel = new BookListViewModel
            {
                Books = _bookRepository.GetAllBooks()
            };

            return View(bookListViewModel);
        }

    }
}
