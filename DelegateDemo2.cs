//// Multi cast delegate
//using System;
//namespace ConsoleApp1WiproTraining
//{
//    public delegate void Delegate_demo(); // declaration
//    class calc
//    {
//        public void add()
//        {
//            int a = 10, b = 20;
//            Console.WriteLine("addition of two number is  " + (a + b));
//        }
//        static void sub()
//        {
//            int a = 10, b = 20;
//            Console.WriteLine("difference of two number is  " + (b - a));
//        }
//        public void multi()
//        {
//            int a = 10, b = 20;
//            Console.WriteLine("multiplication of two number is  " + (a * b));
//        }

//        static void Main()
//        {
//            calc calc = new calc();
//            Delegate_demo obj = new Delegate_demo(calc.add);
//            obj += sub;
//            obj += calc.multi;
//            obj();
          
//        }
//    }


//}

