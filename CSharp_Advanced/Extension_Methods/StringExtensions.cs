using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension_Methods
{
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numOfWords)
        {
            if (numOfWords == 0)
            {
                return "";
            }
            var words = str.Split(" ");
            if (words.Length < numOfWords)
            {
                return str;
            }
            return string.Join(" ", words.Take(numOfWords));
        }
    }
}
