using System;


namespace ConsoleApp1WiproTraining
{
    internal class Expression_Bodied
    {
        class calulator
        {
            public int add(int a, int b) => a + b;
            public int square(int x) => x * x; 
        }
        static void Main(string[] args)
        {
            var calulator = new calulator();
            Console.WriteLine("Addition result " + calulator.add(89, 90));
            Console.WriteLine("Sqaure result " + calulator.square(78));
        }
    }
}
