using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Data;
using Task.Models;
using Task.Services.Interfaces;

namespace Task.Services
{
    public class BookService : IBookService
    {
        public int GetCountOfBooksByAuthor(Func<Book, bool> expression)
        {
            return BookDbContext.books.Count(expression);
        }
    }
}
