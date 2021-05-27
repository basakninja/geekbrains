using System;

namespace _6._Schedule
{
    class Program
    {
        static void Main(string[] args)
        {

            dayOfTheWeek scheduleOffice1 = (dayOfTheWeek)0b_0111100;
            dayOfTheWeek scheduleOffice2 = (dayOfTheWeek)0b_1111111;

            Console.WriteLine($"Office 1 working-days: {scheduleOffice1}");
            Console.WriteLine($"Office 2 working-days: {scheduleOffice2}");


        }
        [Flags]
        enum dayOfTheWeek
        {
            Monday = 0b_0000001,
            Tuesday = 0b_0000010,
            Wednesday = 0b_0000100,
            Thurstday = 0b_0001000,
            Friday = 0b_0010000,
            Saturday = 0b_0100000,
            Sunday = 0b_1000000,
        }
    }
}
