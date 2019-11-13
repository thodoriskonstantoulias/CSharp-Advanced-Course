using System;

namespace Nulls
{
    class Program
    {
        //Lesson 7 : Nullable types
        static void Main(string[] args)
        {
            DateTime? date = null;
            Console.WriteLine(date.GetValueOrDefault());
            Console.WriteLine(date.HasValue);

            DateTime date2 = date ?? DateTime.Today;
            Console.WriteLine(date2);

        }
    }
}
