using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book {Title = "Title 1" , Price = 7},
                new Book {Title = "Title 2" , Price = 7.2f},
                new Book {Title = "Title 3" , Price = 9},
                new Book {Title = "Title 4" , Price = 17}
            };
        }
    }
}
