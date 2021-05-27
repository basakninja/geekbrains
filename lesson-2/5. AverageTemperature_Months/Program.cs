using System;

namespace _5._AverageTemperature_Months

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

            int temperatureAvg = (int.Parse(temperatureMax) + int.Parse(temperatureMin)) / 2;

            Console.WriteLine($"Average temperature: { temperatureAvg }° C");


            string str;
            do
            {
                Console.Write("Please enter the number of the month[1..12]: ");
                str = Console.ReadLine();
            } while (!int.TryParse(str, out var value) || value < 1 || value > 12);




            switch (int.Parse(str))
            {

                case 1:
                    if (temperatureAvg > 0)
                    {


                        Console.WriteLine("January");
                        Console.Write("a wet winter :((((");
                    }
                    else
                    {
                        Console.WriteLine("January");

                    }
                    break;
                case 2:
                    if (temperatureAvg > 0)
                    {

                        Console.WriteLine("February");
                        Console.Write("a wet winter :((((");
                    }
                    else
                    {
                        Console.WriteLine("February");
                    }
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    if (temperatureAvg >= 0)
                    {

                        Console.WriteLine("December");
                        Console.Write("a wet winter :((((");
                    }
                    else
                    {
                        Console.WriteLine("December");
                    }
                    break;
            }

        }
    }
}

