using System;

namespace Extension_Methods
{
    class Program
    {
        //Lesson 5 : Extension Methods
        static void Main(string[] args)
        {
            string post = "just a sentence to prove the extension method works";
            var shortPost = post.Shorten(5);
            Console.WriteLine(shortPost);
        }
    }
}
