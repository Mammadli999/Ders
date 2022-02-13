using System;

namespace ConsoleApp1.Ders_Task_9
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
            l1:
            Console.Write("Eded Daxil Edin: ");

            bool a = int.TryParse(Console.ReadLine(),out int userreqem );

            string v = "";
                switch (userreqem)
                {
                    case 1:
                        {
                            Console.Clear();
                            v = "Yanvar";

                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            v = "Fevral";
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            v = "Mart";
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            v = "Aprel";
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            v = "May";
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            v = "Iyun";
                            break;
                        }
                    case 7:
                        {
                            Console.Clear();
                            v = "Iyul";
                            break;
                        }
                    case 8:
                        {
                            Console.Clear();
                            v = "Avqust";
                            break;
                        }
                    case 9:
                        {
                            Console.Clear();
                            v = "Sentyabr";
                            break;
                        }
                    case 10:
                        {
                            Console.Clear();
                            v = "Oktyabr";
                            break;
                        }
                    case 11:
                        {
                            Console.Clear();
                            v = "Noyabr";
                            break;
                        }
                    case 12:
                        {
                            Console.Clear();
                            v = "Dekabr";
                            break;
                        }
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Shert Odenilmemisdir");
                            goto l1;
                        }

                }
                Console.WriteLine(v);
                Console.WriteLine("Davam Etmek Ucun Enter: ");

            } while (Console.ReadKey().Key == ConsoleKey.Enter);


        }   


    }
}
