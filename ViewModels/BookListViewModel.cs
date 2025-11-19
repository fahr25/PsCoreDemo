using System.Collections.Generic;
using PsCoreDemo.Models;

namespace PsCoreDemo.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; } = new List<Book>();
        public string? CurrentCategory { get; set; }
    }
}