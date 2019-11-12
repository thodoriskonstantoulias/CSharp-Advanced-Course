namespace Delegates
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            System.Console.WriteLine(path);
            return new Photo();
        }
    }
}