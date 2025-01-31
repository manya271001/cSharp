//using System;


//namespace ConsoleApp1WiproTraining
//{
//    class shape
//    {
//        public void displayShape()
//        {
//            Console.WriteLine("welcome to shape class");
//        }
//    }

//    class square : shape { 
//        public int AreaSquare(int side)
//        {
//            Console.Write("area of sqaure is ");
//            return side * side;
//        }    
//    }

//    class rectangle : shape
//    {
//        public int AreaRectangle(int l , int b)
//        {
//            Console.Write("area of rectangle is ");
//            return l*b;
//        }
//    }

//    class octagon : shape
//    {
//        public decimal AreaOctagon(int s)
//        {
//            Console.Write("area of rectabgle is ");
//            decimal result = 2 * 2.414m * s * s;
//            return result;
//        }
//    }
//    internal class HiereachicalInheritance
//    {
//        static void Main(string[] args)
//        {
//            shape s = new shape();
//            s.displayShape();

//            square s1 = new square();
//            Console.WriteLine(s1.AreaSquare(10));
           

//            rectangle rectangle1 = new rectangle();
//            Console.WriteLine(rectangle1.AreaRectangle(10, 10));
            

//            octagon octa = new octagon();
//           Console.WriteLine(octa.AreaOctagon(20));
//        }
//    }
//}
