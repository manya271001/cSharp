//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 5, 2, 9, 1, 5, 6 };
//        Console.WriteLine("Original array:");
//        PrintArray(numbers);

//        BubbleSort(numbers);

//        Console.WriteLine("Sorted array:");
//        PrintArray(numbers);
//    }

//    static void BubbleSort(int[] array)
//    {
//        int n = array.Length;
//        for (int i = 0; i < n - 1; i++)
//        {
//            for (int j = 0; j < n - i - 1; j++)
//            {
//                if (array[j] > array[j + 1])
//                {
//                    // Swap array[j] and array[j + 1]
//                    int temp = array[j];
//                    array[j] = array[j + 1];
//                    array[j + 1] = temp;
//                }
//            }
//        }
//    }

//    static void PrintArray(int[] array)
//    {
//        foreach (int element in array)
//        {
//            Console.Write(element + " ");
//        }
//        Console.WriteLine();
//    }
//}
