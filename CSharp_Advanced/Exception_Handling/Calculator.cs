using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handling
{
    public class Calculator
    {
        public int Divide(int a , int b)
        {
            return a / b;
        }

        public void TestException(int n)
        {
            try
            {
                if (n == 2) throw new Exception("An error occured");
            }
            catch (Exception ex)
            {
                throw new CustomException("You cannot call the method with 2 as input", ex);
            }           
        }
    }
}
