//using System;


//namespace ConsoleApp1WiproTraining
//{
//    abstract class computer
//    {
//        public abstract void detail();
//        public void display()
//        {
//            Console.WriteLine("my comouter detail");
//        }

//    }

//    class mouse : computer
//    {
//        public override void detail()
//        {
//            Console.WriteLine("mouse detail class ");

//        }
//        public new void display()
//        {
//            Console.WriteLine("detail for mouse class");
//        }
//    }
//    internal class abstrat2
//    {
//        static void Main(string[] args)
//        {
//            //computer c1 = new computer(); ----> error cannot create instance of an object class

//            computer c1 = new mouse();
//            c1.display();

//            mouse c2 = new mouse();
//            c2.display();
//        }
//    }
//}
