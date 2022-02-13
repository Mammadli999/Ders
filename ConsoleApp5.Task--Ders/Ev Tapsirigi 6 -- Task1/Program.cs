using System;

namespace Ev_Tapsirigi_6____Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string soz = "Hezi Aslanov Baki Seheri";

            char a;
            char b;

            int countA = 0;
            int countB = 0;

            for (int i = 0; i <soz.Length ; i++)
            {
                if (soz.ToLower()[i] == 'a')
                {
                    countA++;
                }
                else if (soz.ToLower()[i] == 'b')
                {
                    countB++;
                }
            }

            double cavab = countA * 1.0 / countB;
            Console.WriteLine($">>>{cavab}");
        }
    }
}
