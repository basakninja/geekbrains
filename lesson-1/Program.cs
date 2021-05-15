using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            string currentDate = DateTime.UtcNow.ToString("MM dddd yyyy");
            Console.WriteLine($"Hello {userName}, today is {currentDate}");
        }
    }
}
