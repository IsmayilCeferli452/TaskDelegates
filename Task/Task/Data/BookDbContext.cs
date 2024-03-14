using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Models;

namespace Task.Data
{
    public class BookDbContext 
    {
        public static List<Book> books;

        static BookDbContext()
        {
            books = new List<Book>()
            {
                new Book
                {
                    Id = 1,
                    Title = "Leyli ve Mecnun",
                    Author = "Nizami Gencevi",
                },
                new Book
                {
                    Id = 2,
                    Title = "Isgendername",
                    Author = "Nizami Gencevi",
                },
                new Book
                {
                    Id = 3,
                    Title = "Leyli ve Mecnun",
                    Author = "Mehemmed Fuzuli",
                },
                new Book
                {
                    Id = 4,
                    Title = "Xosrov ve Sirin",
                    Author = "Elisir Nevai",
                },
            };
        }
    }
}
