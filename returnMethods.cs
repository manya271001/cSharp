//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1WiproTraining
//{
//    internal class ReturnMethods
//    {
//        static void Main(string[] args)
//        {
//            ReturnMethods ob = new ReturnMethods();
//            Console.WriteLine($" addition is : {ob.add2(20, 55)}");
//            ReturnMethods ob2 = new ReturnMethods();
//            Console.WriteLine($" substraction is : {ob2.sub(20, 55)}");
//            ReturnMethods ob3 = new ReturnMethods();
//            Console.WriteLine($" multiplication is : {ob3.mul(20, 55)}");

//            ReturnMethods ob4 = new ReturnMethods();
//            Console.WriteLine($" factorial is : {ob4.fact(9)}");
//            ReturnMethods ob5 = new ReturnMethods();
//            ob5.prime(3);
//            ReturnMethods ob6 = new ReturnMethods();
//            ob6.Fibo();

//        }
//        public int add(int a, int b)
//        {
//            return (a + b);
//        }
//        public int sub(int a, int b)
//        {
//            return (a - b);
//        }
//        public int mul(int a, int b)
//        {
//            return (a * b);
//        }
//        //public int add2(object a , object b)
//        //{
//        //    int num1 = (int)a;
//        //    int num2= (int)b;
//        //    object sum = num1 + num2;
//        //    int finalSum = (int)sum;

//        //    return (finalSum);
//        //}
//        public object add2(object a, object b)
//        {

//            object sum = (int)a + (int)b;
//            return (sum);
//        }
//        public int fact(int num)
//        {
//            int p = 1;
//            while (num > 0)
//            {
//                p = p * num;
//                num--;
//            }
//            return p;
//        }

//        public void prime(int num) 
//        {

//            int k = num - 1;
//            bool flag = false;
//            while (k > 1) { 
//            if(num % k == 0)
//                {
//                    flag = true;
//                    break;
//                }
//            k--;
//            }
//            if (flag) {
//                Console.WriteLine("not number");
//            }
//            else
//            {
//                Console.WriteLine(" prime");
//            }
//         }
//        public void Fibo()
//        {
//            int a = 0, b = 1, sum;

//            Console.Write(a + "\t" + b + "\t"); 

//            for (int i = 2; i < 50; i++) 
//            {
//                sum = a + b;
//                if (sum > 50) 
//                    break;

//                Console.Write(sum + "\t");

//                a = b;
//                b = sum;
//            }
//        }




//    }
//}
