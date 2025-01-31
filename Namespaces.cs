//using System;

//namespace first
//{
//    class c1
//    {
//        public void function1()
//        {
//            Console.WriteLine("namspace 1 function 1");
//        }
//    }
//}
//namespace second
//{
//    class c2
//    {
//        public void function2()
//        {
//            Console.WriteLine("namspace 2 function 2");
//        }
//    }
//}

//namespace ConsoleApp1WiproTraining
//{
// internal class Namespaces
//    {
//        static void Main(string[] args)
//        {
//            second.c2 c2 = new second.c2();
//            c2.function2();

//        }
//    }
//}


//namespace MyNamespace
//{
//    public class BaseClass
//    {
//        protected internal void ProtectedInternalMethod()
//        {
//            Console.WriteLine("Hello from ProtectedInternalMethod!");
//        }
//    }
//    public class DerivedClass : BaseClass
//    {
//        public void CallProtectedInternalMethod()
//        {
//            // Accessible within derived class
//            ProtectedInternalMethod();
//        }
//    }

//    class Program
//    {
//        //static void Main(string[] args)
//        //{
//        //    BaseClass baseClass = new BaseClass();
//        //    DerivedClass derivedClass = new DerivedClass();

//        //    // Accessible within the same assembly
//        //    baseClass.ProtectedInternalMethod();

//        //    derivedClass.CallProtectedInternalMethod();
//        //}
//    }
//}