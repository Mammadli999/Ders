using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numberCharCodes = Enumerable.Range(48, 10).ToArray();
            //string word = "1234abbas1234";

            //string newText = Regex.Replace(word, @"=?\d+", string.Empty);

            //for (int i = 0; i < word.Length; i++)
            //{
            //    byte charCode = (byte)word[i];

            //    if(Array.IndexOf(numberCharCodes,charCode) == -1)

            //    newText = newText + word[i];
            //}

            //Console.WriteLine(newText);
           // DateTime date1 = DateTime.Now;
           // DateTime date2 = DateTime.UtcNow;
            DateTime date3 = DateTime.Today;
           // Console.WriteLine(date1);
           // Console.WriteLine(date2);
            Console.WriteLine(date3);
        }
    }
}
