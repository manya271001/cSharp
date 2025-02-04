using System;


namespace ConsoleApp1WiproTraining
{
    public delegate void Print(int val);
    public delegate void add(int val1,int val2);

    internal class AnonymusFunctions
    {
        static void Main(string[] args)
        {
            Print print = delegate (int val)
            {
                Console.WriteLine("Inside Anonymus method value: {0}", val);
            };
            print(89);

            add a = delegate (int val,int val2)
            {
                Console.WriteLine("Inside Anonymus method sum is" + (val+val2));
            };
            a(89,78);


        }
    }
}
