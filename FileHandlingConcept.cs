using System;
using System.IO;


namespace ConsoleApp1WiproTraining
{
    internal class FileHandlingConcept
    {
        static void Main(string[] args)
        {
            FileInfo f1 = new FileInfo(@"C:\Users\Manya sharma\OneDrive\Documents\Manya Sharma.docx");
            Console.WriteLine(f1.FullName);
            Console.WriteLine(f1.Name);
            Console.WriteLine(f1.Extension);
            Console.WriteLine(f1.Length);
            Console.WriteLine(f1.LastAccessTime);
            Console.WriteLine(f1.CreationTime);
        }
    }
}
