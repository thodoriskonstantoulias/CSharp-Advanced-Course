using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class GenericList<T>
    {
        public void Add(T value)
        {
            Console.WriteLine("Number is {0}", value);
        }

    }
}
