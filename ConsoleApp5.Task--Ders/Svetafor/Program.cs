using System;
using System.Text;
using System.Threading;

namespace Svetafor
{
   internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                string Ishiqfor = PrintColor(Svetafor.Red);
                Console.WriteLine(Ishiqfor);
                Thread.Sleep(3000);

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Ishiqfor = PrintColor(Svetafor.Yellow);
                Console.WriteLine(Ishiqfor);
                Thread.Sleep(3000);

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Ishiqfor = PrintColor(Svetafor.Green);
                Console.WriteLine(Ishiqfor);
                Thread.Sleep(3000);
                Console.ForegroundColor = ConsoleColor.White;

            }


        }

        static string PrintColor(Svetafor value)
        {
            switch (value)
            {
                case Svetafor.Red:
                    return "Red";
                case Svetafor.Yellow:
                    return "Yellow";
                case Svetafor.Green:
                    return "Green";
                default:
                    throw new Exception();
            }
        }
    }
}
