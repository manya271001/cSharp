//using System;
//using System.Security.Cryptography.X509Certificates;


//namespace ConsoleApp1WiproTraining
//{
//    class InavlidAgeException:Exception
//    {
//        public InavlidAgeException(string message) : base(message) { }
//    }
//    internal class exceptionDemo2
//    {
//        static void isValid(int age)
//        {
//            if (age < 18)
//            {
//                throw new InavlidAgeException("sorry , your age is not valid ");
//            }
//        }
//        static void Main(string[] args)
//        {
//            try
//            {
//                isValid(4);
//            }
//            catch (InavlidAgeException e) 
//            { 
//                Console.WriteLine(e.Message);
//            }
//            Console.WriteLine("rest of the code will be executed");
//        }
//    }
//}
