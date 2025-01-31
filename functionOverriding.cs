//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1WiproTraining
//{
//    class demo
//    {
//        public virtual void addition(int a , int b)
//        {
//            Console.WriteLine(a+b);
//        }
//    }
//    class demo2 : demo {
//        public override void addition(int a, int b)
//        {
//            base.addition(a, b);
//        }
//    }
//    internal class functionOverriding
//    {
//        static void Main(string[] args)
//        {
//            demo2 demo = new demo2();
//            demo.addition(1, 2);

//            demo.addition(2, 3);
//            demo obj = new demo2();
//            obj.addition(3, 4);
//        }
//    }
//}
