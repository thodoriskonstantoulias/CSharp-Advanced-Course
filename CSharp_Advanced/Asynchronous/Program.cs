using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Asynchronous
{
    class Program
    {
        //Lesson 10 : Asynchronous Programming
        static async Task Main(string[] args)
        {
            await DownloadHtmlAsync("http://msdn.microsoft.com");
            Console.WriteLine("Finished");
        }
        public static async Task DownloadHtmlAsync(string url)
        {
            var client = new WebClient();
            var html = await client.DownloadStringTaskAsync(url);
            using (var streamReader = new StreamWriter(@"D:\Users\results.html"))
            {
                await streamReader.WriteAsync(html);
            }
        } 
    }
}
