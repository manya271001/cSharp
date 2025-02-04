//// Multi cast delegate
//using System;
//namespace ConsoleApp1WiproTraining
//{
//    public delegate void Delegate_demo(); // declaration
//    public delegate void Delegate_demo2(int a , int b);
//    class calc
//    {
//        public void add( int a , int b)
//        {
           
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
//            Delegate_demo2 obj2 = new Delegate_demo2(calc.add);
//            obj2(10, 30);
//            Delegate_demo obj = new Delegate_demo(sub);
//            obj += calc.multi;
//            obj();

//        }
//    }


//}

