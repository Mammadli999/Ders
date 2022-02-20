using System;
using System.Text;

namespace Traffic_Lighst.User_Terefinden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("----Traffic Lights----");

            Type myType = typeof(TrafficLights);
            
            string[] names = Enum.GetNames(myType);

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------");
            l1:
            Console.Write("Reng: ");
            string color = Console.ReadLine();

            if (!Enum.TryParse(color, out TrafficLights light))
            {
                goto l1;
            }

            switch (light)
            {
                case TrafficLights.Red:
                    Console.WriteLine("Qirmizi");
                    break;
                case TrafficLights.Yellow:
                    Console.WriteLine("Sari");
                    break;
                case TrafficLights.Green:
                    Console.WriteLine("Yashil");
                    break;
                default:
                    break;
            }
        }
    }
}
