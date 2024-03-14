using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Services;
using Task.Services.Interfaces;

namespace Task.Controllers
{
    internal class BookController
    {
        private readonly IBookService _bookService;

        public BookController()
        {
            _bookService = new BookService();
        }

        public void GetCountOfBooksByAuthor()
        {
            int result = _bookService.GetCountOfBooksByAuthor(m => m.Author == "Nizami Gencevi");

            Console.WriteLine(result);
        }
    }
}
