//// selection sort
//using System;//class Program//{//    static void Main()//    {//        int[] numbers = { 64, 25, 12, 22, 11 };//        Console.WriteLine("Original array:");//        PrintArray(numbers);//        SelectionSort(numbers);//        Console.WriteLine("Sorted array:");//        PrintArray(numbers);//    }
//    static void SelectionSort(int[] array)
//    {
//        int n = array.Length;    //5
//        for (int i = 0; i < n - 1; i++)
//        {
//            // Find the minimum element in the unsorted sublist
//            int minIndex = i;

//            for (int j = i + 1; j < n; j++)
//            {
//                if (array[j] < array[minIndex])
//                {
//                    minIndex = j;
//                }
//            }

//            // Swap the found minimum element with the first element
//            int temp = array[minIndex];
//            array[minIndex] = array[i];
//            array[i] = temp;
//        }
//    }
//    static void PrintArray(int[] array)//    {//        foreach (int element in array)//        {//            Console.Write(element + " ");//        }//        Console.WriteLine();//    }//}