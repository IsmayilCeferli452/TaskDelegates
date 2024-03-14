using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Models;

namespace Task.Services.Interfaces
{
    internal interface IBookService
    {
        public int GetCountOfBooksByAuthor(Func<Book, bool> expression);
    }
}
