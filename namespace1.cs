using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1WiproTraining
{
    namespace namespace1
    {
        class factorial
        {
            public int Fact(int num)
            {
                int p = 1;
                while (num > 0)
                {
                    p = p * num;
                    num--;
                }
                return p;
            }
        }
    }
}
