//using System;


//namespace ConsoleApp1WiproTraining
//{
//    //----till 7.3 version of c#-------//
//    // function signature only 

//    //-----IMPLICIT INTERFACE--------//
//    interface ICalc
//    {
    
//        void addition();
//        void substraction();
//    }
//    interface ICalc2
//    {
//       void multiplication();
//        void modulus();
//    }

//    class calculate : ICalc, ICalc2
//    {
//        // implementing interface by providing function defination
//        int a = 30;
//        int b = 70;
//        public void addition()
//        {
//            Console.WriteLine(a + b);
//        }

//        public void substraction()
//        {
//            Console.WriteLine(b-a);
//        }

//        public void multiplication() {
//            Console.WriteLine(a * b);        
//        }
//            //-----EXPLICIT INTERFACE---//
//            // calling interface with its name
//         void ICalc2.modulus() { 
//            Console.WriteLine(b%a);
//        }
//    }
//        internal class newInterfaceDemo
//        {
//        static void Main(string[] args)
//        {
//            // ERROR
//         //   Calc calc = new calc();
//            calculate calculate  = new calculate();
//            calculate.addition();

//            // we can create object of interface and initialize it to the class
//            ICalc cal = new calculate();
//            cal.addition();
//            cal.substraction();

//            ICalc2 cal2 = new calculate();
//            cal2.multiplication();
//            cal2.modulus();
//            // error ----> calculate.modulus();
//        }
//    }
    
//}