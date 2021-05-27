using System;

namespace CheckForParty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number: ");
            string entredNumber = Console.ReadLine();

            while (!int.TryParse(entredNumber, out int num))
            {
                Console.Write("Invalid value entered.\nPlease enter number: ");
                entredNumber = Console.ReadLine();
            }

        }
    }
}
