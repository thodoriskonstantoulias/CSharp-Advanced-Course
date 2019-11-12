using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        //Lesson 6 : LINQ
        static void Main(string[] args)
        {
            //LINQ Extension Methods
            var books = new BookRepository().GetBooks();

            var cheapBooks = books.Where(x => x.Price < 10).Select(x => x.Title);
            foreach (var book in cheapBooks)
            {
                //Console.WriteLine(book.Title);
                Console.WriteLine(book);
            }

            //LINQ Queries
            var cheapBooks2 = from b in books
                              where b.Price < 10
                              select b.Title;

            foreach (var book in cheapBooks2)
            {
                //Console.WriteLine(book.Title);
                Console.WriteLine(book);
            }

            Console.WriteLine("-----------");
            //Return a single book

            //var singleBook = books.Single(b => b.Title == "Title 3");
            var singleBook = books.SingleOrDefault(b => b.Title == "Title 3");
            Console.WriteLine(singleBook.Title);

            //Skip data 
            Console.WriteLine("-----------");
            var chosenBooks = books.Skip(2);
            foreach (var book in chosenBooks)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
