using System;

namespace Delete
{
    class Program
    {
        static void Main(string[] args)
        {
            string wSpace = new string(' ', Console.WindowWidth);

            
            Console.WriteLine("Demo");
            Console.WriteLine("The End");
            Console.CursorTop--;
            Console.WriteLine(wSpace);
            Console.CursorTop--;
        }
    }
}
