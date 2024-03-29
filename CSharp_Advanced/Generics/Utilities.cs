﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Utilities<T> where T : IComparable
    {
        public int Max(int a , int b)
        {
            return a > b ? a : b;
        }
        //Generic equivalent is :
        public T Max(T a, T b) 
        {           
            return a.CompareTo(b) > 0  ? a : b;
        }
    }
}
