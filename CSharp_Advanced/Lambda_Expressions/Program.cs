using System;

namespace Lambda_Expressions
{
    class Program
    {
        // Lesson 3 : Lambda Expressions
        static void Main(string[] args)
        {
            //ex1
            //return square with lambda

            //Func<int,int> square = number => number * number;
            //Console.WriteLine(square(5));

            //ex2
            //const int factor = 5;
            //Func<int, int> multiplier = number => number * factor;
            //Console.WriteLine(multiplier(6));

            //ex3
            var books = new BookRepository().GetBooks();
            var expensiveBooks = books.FindAll(x => x.Price > 10);
            foreach (var item in expensiveBooks)
            {
                Console.WriteLine(item.Title);
            }
          
        }
    }
}
