using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstNamespace
{

    class first
    {
        public void function1()
        {
            Console.WriteLine("first class function");
        }
    }
    namespace second
    {
        class second
        {
            public void function2()
            {
                Console.WriteLine("second class function");
            }
        }

    }
}

class program
{
    static void Main(string[] args)
    {
        {
            firstNamespace.first ob = new firstNamespace.first();
            ob.function1();

            firstNamespace.second.second ob2 = new firstNamespace.second.second();
            ob2.function2 ();
        }
    }
}