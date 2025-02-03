//using System;


//namespace ConsoleApp1WiproTraining
//{
//    internal class Tuples
//    {
//        static void Main(string[] args)
//        {
//            var t = ("hello",123,true,false);
//            Console.WriteLine(t);

//            Console.WriteLine(t.Item1);
//            Console.WriteLine(t.Item2);
//            Console.WriteLine(t.Item3);
//            Console.WriteLine(t.Item4);


//            // initalising tuple using a constructor

//            Tuple<string> t1 = new Tuple<string>("hello");
//            Tuple<string, int> t2 = new Tuple<string, int>("manya", 670);
//            Tuple<int, int, int, int, int, int, int, Tuple<int>> t3 = 
//                new Tuple<int, int, int, int, int, int, int, Tuple<int>>(1, 2, 3, 4, 5, 6, 7, new Tuple<int>(8));

//            Console.WriteLine(t1);
//            Console.WriteLine(t2);
//            Console.WriteLine(t3);

//            //deconstructor
//            var person = ("manya", 23);
//            (string name , int age) = person;
//            Console.WriteLine(name);
//            Console.WriteLine(age);
   
//        }
//    }
//}
