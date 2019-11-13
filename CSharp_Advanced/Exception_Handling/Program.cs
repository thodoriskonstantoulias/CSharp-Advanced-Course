using System;
using System.IO;

namespace Exception_Handling
{
    class Program
    {
        //Lesson 9 : Exception Handling
        static void Main(string[] args)
        {
            // ex1

            //try
            //{
            //    var calc = new Calculator();
            //    Console.WriteLine(calc.Divide(5, 0));
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("You cannot divide by zero");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An error occured!");
            //    Console.WriteLine(ex.Message);
            //}

            //ex2

            //StreamReader streamReader = null;
            //try
            //{
            //    streamReader = new StreamReader(@"c:\file.zip");
            //    var content = streamReader.ReadToEnd();
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("An error occured!");
            //}
            //finally
            //{
            //    if (streamReader != null)
            //    {
            //        streamReader.Dispose();
            //    }               
            //}

            ////ex2 alternative

            //try
            //{
            //    using (var streamReader2 = new StreamReader(@"c:\file.zip"))
            //    {
            //        var content2 = streamReader.ReadToEnd();
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("A second error occured!");
            //}

            //ex3 - Custom exceptions
            try
            {
                var calc2 = new Calculator();
                calc2.TestException(2);
                Console.WriteLine("OK");
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Custom error : " + ex.Message );
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }
    }
}
