//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1WiproTraining
//{
//    internal class Array
//    {
//        static void Main(string[] args)
//        {

//            //// first way to declare array
//            //int[] arr=new int[10];
//            //arr[0] = 1;
//            //arr[1] = 2;
//            //arr[2] = 3;
//            //arr[3] = 4;
//            //arr[4] = 5;

//            //for(int i=0;i<arr.Length; i++)
//            //{
//            //    Console.WriteLine(arr[i]);
//            //}

//            //// second way
//            //int[] arr2 = { 1, 2, 4, 5, 6, 87 };
//            //for (int i = 0; i < arr2.Length; i++)
//            //{
//            //    Console.WriteLine(arr2[i]);
//            //}

//            ////third way
//            //int[] arr3 = new int[10] { 1, 2, 4, 5, 6, 7, 8, 9, 10,8 };

//            //for (int i = 0; i < arr3.Length; i++)
//            //{
//            //    Console.WriteLine(arr3[i]);
//            //}
//            ////forurth way
//            //int[] arr4 = new int[] { 1, 2, 4 };
//            //for (int i = 0; i < arr4.Length; i++)
//            //{
//            //    Console.WriteLine(arr4[i]);
//            //}

//            // double dimension 
//            //int[,] arr =
//            //{
//            //    {1,2,4,4 },
//            //    {1,2,4,6 }
//            //};
//            //for (int i = 0; i < arr.GetLength(0); i++) { 
//            //    for(int j = 0; j < arr.GetLength(1); j++)
//            //    {
//            //        Console.WriteLine(arr[i,j]);
//            //    }
//            //}

//            // addition of matrix

//            //int row = 2;
//            //int coloumn = 2;

//            //int[,] arr1 = { { 1, 2 }, { 3, 4 } };
//            //int[,] arr2 = { { 1, 2 }, { 3,4 } };

//            //int[,] result = new int[ row, coloumn];

//            //for(int i =0;i<result.GetLength(0);i++) 
//            //    { 
//            //        for(int j = 0; j < result.GetLength(1); j++)
//            //    {
//            //        result[i,j] = arr1[i,j] + arr2[i,j];
//            //    }

//            //}

//            //for (int i = 0; i < result.GetLength(0); i++)
//            //{
//            //    for (int j = 0; j < result.GetLength(1); j++)
//            //    {
//            //        Console.Write(result[i,j]+"\t" );
//            //    }
//            //    Console.WriteLine();

//            //}

//            //foreach

//            //int[ ] arr = { 1, 2, 3 };
//            //foreach (int i in arr) { 
//            //    Console.WriteLine(i);            
//            //}

//            //jagged array

//            //int[][] arr = new int[3][];
//            // arr[0] = new int[2];
//            //arr[1] = new int[2];
//            //arr[2] = new int[2];

//            //arr[0][0] = 1;
//            //arr[0][1] = 7;

//            //arr[1][0] = 76;
//            //arr[1][1] = 4;

//            //arr[2][0] = 5;
//            //arr[2][1] = 34;

//            //for (int i = 0; i < arr.Length; i++) { 
            
//            //    for(int j = 0; j < arr[i].Length; j++)
//            //    {
//            //        Console.Write(arr[i][j] + " ");
//            //    }
//            //    Console.WriteLine();
//            //}

            
//            int[,] matrix = new int[3, 3];

            
//            Console.WriteLine("Enter the elements of the 3x3 matrix:");
//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < 3; j++)
//                {
//                    Console.Write($"Element [{i},{j}]: ");
//                    matrix[i, j] = int.Parse(Console.ReadLine());
//                }
//            }

//            Console.WriteLine("\nThe matrix is:");
//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < 3; j++)
//                {
//                    Console.Write(matrix[i, j] + "\t");
//                }
//                Console.WriteLine();
//            }

//            Console.WriteLine("\nSecondary diagonal elements are:");
//            for (int i = 0; i < 3; i++)
//            {
//                Console.WriteLine(matrix[i, 2 - i]);

//            }

//            }
//    }
//}
