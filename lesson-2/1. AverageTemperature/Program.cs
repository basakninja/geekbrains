using System;

namespace lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter min temperature [°C]: ");
            string temperatureMin = Console.ReadLine();

            while (!int.TryParse(temperatureMin, out int num))
            {
                Console.Write("Invalid value entered.\nPlease enter min temperature (int): ");
                temperatureMin = Console.ReadLine();
            }


            Console.Write("Please enter max temperature [°C]: ");
            string temperatureMax = Console.ReadLine();

            while (!int.TryParse(temperatureMax, out int num))
            {
                Console.Write("Invalid value entered.\nPlease enter max temperature (int): ");
                temperatureMax = Console.ReadLine();
            }


            Console.WriteLine($"Average temperature: { (int.Parse(temperatureMax) + int.Parse(temperatureMin)) / 2}° C");

        }
    }
}