//using System;
//using System.IO;


//namespace ConsoleApp1WiproTraining
//{
//    internal class FileHandlingConcept
//    {
//        static void Main(string[] args)
//        {
//            //FileInfo f1 = new FileInfo(@"C:\Users\Manya sharma\OneDrive\Documents\Manya Sharma.docx");
//            //Console.WriteLine(f1.FullName);
//            //Console.WriteLine(f1.Name);
//            //Console.WriteLine(f1.Extension);
//            //Console.WriteLine(f1.Length);
//            //Console.WriteLine(f1.LastAccessTime);
//            //Console.WriteLine(f1.CreationTime);

//            //DriveInfo d = new DriveInfo("c:\\");
//            //Console.WriteLine(d.Name);
//            //Console.WriteLine(d.TotalSize);
//            //Console.WriteLine(d.AvailableFreeSpace);

//            //DirectoryInfo d2 = new DirectoryInfo(@"c:\documents");
//            //Console.WriteLine(d2.Name);
//            //Console.WriteLine(d2.Extension);
//            // Console.WriteLine(d2.CreationTime);

//            string filePath1 = @"C:\Users\Manya sharma\OneDrive\Documents\new.docx";
//            string content1;
//            //read file using streamReader
//            using (StreamReader sr = new StreamReader(filePath1))
//            {
//                content1= sr.ReadToEnd();
//                Console.WriteLine(content1);
//            }

//            // read file using ReadToEnd()

//            //content = File.ReadAllText(filePath);
//            //Console.WriteLine(content);

//            // write to the file usin streamWriter
//            string content = "HELLO ALL MY NAME IS MANYA";
//            string filePath = @"C:\Users\Manya sharma\OneDrive\Documents\new.docx";
//            using (StreamWriter sw = new StreamWriter(filePath)) {
//               sw.Write(content);
//            }
//        }
//    }
//}
