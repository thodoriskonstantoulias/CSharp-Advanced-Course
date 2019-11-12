using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda_Expressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{Title="Title 1",Price=6},
                new Book{Title="Title 2",Price=8},
                new Book{Title="Title 3",Price=97}
            };
        }
    }
}
