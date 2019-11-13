using System;

namespace Dynamics
{
    class Program
    {
        //Lesson 8 : Dynamics
        static void Main(string[] args)
        {
            dynamic name = "Ted";
            name = 10;
            Console.WriteLine(name);

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b;
            Console.WriteLine(c);

            int i = 5;
            dynamic d = i;
            Console.WriteLine(d);
        }
    }
}
