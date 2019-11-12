using System;

namespace Delegates
{
    class Program
    {
        //Lesson 2 : Delegates
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterhandler = filters.ApplyBrightness;
            filterhandler += filters.ApplyContrast;

            processor.Process("image.jpg", filterhandler);
        }
    }
}
