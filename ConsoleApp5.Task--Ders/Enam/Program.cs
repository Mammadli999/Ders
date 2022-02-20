using System;
using System.Text;

namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            string GenderText = PrintGender(Gender.Male);
            Console.WriteLine(GenderText);

            GenderText = PrintGender(Gender.Female);
            Console.WriteLine(GenderText);

        }

        static string PrintGender(Gender value)
        {
            switch (value)
            {
                case Gender.Male:
                    return "Kishi";
                case Gender.Female:
                    return "Qadin";
                default:
                    throw new Exception("");
            }
        }
    }
}
