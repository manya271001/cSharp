
//// singnle cast delegate
//using System;
//namespace ConsoleApp1WiproTraining
//{
//    public delegate void Delegate_demo(); // declaration
//    class calc
//    {
//        public void add()
//        {
//            int a = 10, b = 20;
//            Console.WriteLine("addition of two number is  " + (a+b));
//        }
//        public void sub()
//        {
//            int a = 10, b = 20;
//            Console.WriteLine("difference of two number is  " + (b-a));
//        }
//        public void multi()
//        {
//            int a = 10, b = 20;
//            Console.WriteLine("multiplication of two number is  " + (a * b));
//        }

//        static void Main()
//        {
//            calc calc = new calc();
//            Delegate_demo obj = new Delegate_demo(calc.add); // assign
//            obj(); //call
//            Delegate_demo obj2 = new Delegate_demo(calc.sub);
//            obj2();
//            Delegate_demo obj3 = new Delegate_demo(calc.multi);
//            obj3();
//        }
//    } 


//    } 
