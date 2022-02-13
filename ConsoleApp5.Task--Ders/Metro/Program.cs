using System;
using System.Text;
using System.Threading;

namespace Metro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.Unicode;
            //string word = "Hezi Aslanov ";

            //char first;

            //Console.ForegroundColor = ConsoleColor.Green;
            //do
            //{
            //    Console.Clear();
            //    Console.WriteLine(word);
            //    first = word[0];
            //    word = word.Substring(1) + first;
            //    Thread.Sleep(100);
            //} while (true);

            string word = "Hezi Aslanov ";
            char first;
            Console.ForegroundColor = ConsoleColor.Green;

            do
            {
                Console.Clear();
                Console.WriteLine(word);
                first = word[word.Length-1];
                word = first + word.Substring(0,word.Length-1);
                Thread.Sleep(100);

            } while (true);




        }
    }
}
