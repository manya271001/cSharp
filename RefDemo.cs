//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 10, 20, 30, 40 };
//        foreach (int number in numbers)
//        {
//            Console.WriteLine(number);
//        }
//        // Get reference to an element
//        ref int refToElement = ref GetElement(numbers, 2);

//        // Modify through the reference
//        refToElement = 99;
//        Console.WriteLine("after changing the values");    
//        foreach (int number in numbers)
//        { 
//            Console.WriteLine(number);
//        }
//    }

//    static ref int GetElement(int[] arr, int index)
//    {
//        return ref arr[index]; // Return reference to array element
//    }
//}

