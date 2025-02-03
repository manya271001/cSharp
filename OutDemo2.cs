//using System;

//class Program
//{
//    static void Main()
//    {
//        string numberString = "25.0";
//        if (TryParseAndCalculateSquareRoot(numberString, out double number, out double squareRoot))
//        {
//            Console.WriteLine($"Parsed number: {number}");
//            Console.WriteLine($"Square root: {squareRoot}");
//        }
//        else
//        {
//            Console.WriteLine("Parsing or square root calculation failed.");
//        }
//    }

//    static bool TryParseAndCalculateSquareRoot(string input, out double number, out double squareRoot)
//    {
//        // Initialize out parameters
//        number = 0;
//        squareRoot = 0;

//        // Try to parse the string into a double
//        if (double.TryParse(input, out number))
//        {
//            // Calculate the square root if parsing is successful
//            if (number >= 0)
//            {
//                squareRoot = Math.Sqrt(number);
//                return true;
//            }
//        }

//        return false;
//    }
//}
