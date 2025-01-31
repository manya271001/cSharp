using System;


namespace ConsoleApp1WiproTraining
{
class enumeration
    {
        enum daysofWeek
        {
            sunday,
            monday,
            tuesday,
            wednesday,
             thrusday,
             friday,
             saturday
        }
        static void Main(string[] args)
        {
            daysofWeek today = daysofWeek.wednesday;
            Console.WriteLine($"today is : {today}");

            int value = (int)today;
            Console.WriteLine(value);
        }
    }
}
