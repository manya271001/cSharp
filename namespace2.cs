using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1WiproTraining
{
    namespace namespace2
    {
        class Prime
        {
            public void prime(int num)
            {

                int k = num - 1;
                bool flag = false;
                while (k > 1)
                {
                    if (num % k == 0)
                    {
                        flag = true;
                        break;
                    }
                    k--;
                }
                if (flag)
                {
                    Console.WriteLine("not number");
                }
                else
                {
                    Console.WriteLine(" prime");
                }
            }
        }
    }
}
