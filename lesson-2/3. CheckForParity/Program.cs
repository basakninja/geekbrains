using System;

namespace CheckForParity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number: ");
            string enteredNumber = Console.ReadLine();

            while (!int.TryParse(enteredNumber, out int num))
            {
                Console.Write("Invalid value entered.\nPlease enter number: ");
                enteredNumber = Console.ReadLine();
            }


            if (int.Parse(enteredNumber) % 2 == 0)
            {
                Console.Write($"Number {enteredNumber} is even");
            } else
            {
                Console.Write($"Number {enteredNumber} is odd");
            }


        }
    }
}