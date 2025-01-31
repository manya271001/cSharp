using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1WiproTraining
{
    namespace namespace3
    {
        class Fibo
        {
            public void fibo()
            {
                int a = 0, b = 1, sum;

                Console.Write(a + "\t" + b + "\t");

                for (int i = 2; i < 50; i++)
                {
                    sum = a + b;
                    if (sum > 50)
                        break;

                    Console.Write(sum + "\t");

                    a = b;
                    b = sum;
                }
            }
        }
    }
}
