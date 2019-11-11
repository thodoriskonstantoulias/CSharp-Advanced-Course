using System;

namespace Generics
{
    class Program
    {
        //Lesson 1 : Generics
        static void Main(string[] args)
        {
            var numbers = new Utilities<int>();
            Console.WriteLine(numbers.Max(10, 5)); 
        }
    }
}
