//using System;

//namespace ConsoleApp1WiproTraining
//{
//    internal class exceptionDemo3
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                divide(10, 0);
//            }
//            catch (DivideByZeroException ex) when (LogException(ex)) 
//            {
//                Console.WriteLine("handled divide by log exception");
//            }
//            catch(Exception ex) when (ex.Message.Contains("specific string"))
//            {
//                Console.WriteLine("handled an exception with specefic message condition");
//            }

//        }

//        static int divide(int num,int deno)
//        {
//            return num / deno;
//        }
//        static bool LogException(Exception ex) {
//            //Log the exception (for example , to a file or a monitoring system)

//            Console.WriteLine($"Exception Logged: {ex.Message}");
//            return true;  // returning true means exception will be caught
//        }
//    }
//}

using System;
 namespace exception_demo
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new Exception("this is sepcefic condition error");
            }
            catch (Exception ex) when(ex.Message.Contains("specefic condition")) 
            {
                Console.WriteLine("Handled an exception with specefic message condition");
            }
            catch (Exception ex) when (ex.Message.Contains("manya exception"))
            {
                Console.WriteLine("Handled an exception manya with specefic message condition");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unhandled exception : {ex.Message}");
            }

        }
    }
}
