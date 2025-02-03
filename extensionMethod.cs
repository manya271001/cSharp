//using System;


//namespace ConsoleApp1WiproTraining
//{
//    public class oldclass
//    {
//        public int x = 100;
//        public void test1() {
//            Console.WriteLine("test 1 method called" + x);
//        }
//        public void test2()
//        {
//            Console.WriteLine("test 2 method called" + x);
//        }
//    }

//    public static class NewClass
//    {
//        public static void test3(this oldclass obj)
//        {
//            Console.WriteLine("test 3 method called");
//        }
//        public static void test4(this oldclass obj,int x)
//        {
//            Console.WriteLine("test 3 method called" + x);
//        }
//        public static void test5(this oldclass obj)
//        {
//            Console.WriteLine("test 3 method called" + obj.x);
//        }

//    }
//    internal class extensionMethod
//    {
//        static void Main(string[] args)
//        {
//            oldclass obj = new oldclass();
//            obj.test1();
//            obj.test2();
//            obj.test3();
//            obj.test4(78);

//        }
//    }
//}

//using System;
//namespace extension_methods
//{
//    public static class DateTimeExtension
//    {
//        public static bool IsWeekend(this DateTime date) {
//            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
//        }
//    }
//    class program
//    {
//        static void Main(string[] args)
//        {
//            DateTime today = DateTime.Now;
//            bool isWeekend=today.IsWeekend();
//            Console.WriteLine("today is weekend " + isWeekend);
//        }
//    }
//}