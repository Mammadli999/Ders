using System;

namespace ConsoleApp5.Task__Ders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded Daxil Edin");

            int reqem = Convert.ToInt32(Console.ReadLine());
            
            string v = "";
            int qaliq = reqem % 10;

            while (qaliq > 7 || qaliq < 1)
            {

                reqem = reqem / 10;

                qaliq = reqem % 10;

            }


            switch (qaliq)
            {
                case 1:
                    {
                        v = "I Gun";
                        break;
                    }
                case 2:
                    {
                        v = "II Gun";
                        break;
                    }
                case 3:
                    {
                        v = "III Gun";
                        break;
                    }
                case 4:
                    {
                        v = "IV Gun";
                        break;
                    }
                case 5:
                    {
                        v = "V Gun";
                        break;
                    }
                case 6:
                    {
                        v = "VI Gun";
                        break;
                    }
                case 7:
                    {
                        v = "VI Gun";
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Eded duzgun deyil");
                        break;
                    }
            }
                    Console.WriteLine(v);
            Console.ReadKey();
        }
    }
}
