//using System;


//namespace ConsoleApp1WiproTraining
//{
//    class Employee
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Description { get; set; }

//    }

//    class Book
//    {
//        private string title = "my first book";

//        public string Title
//        {
//            get { return title; } // read only property
//        }

//        public string Description
//        {
//            set { Description = value; } // write only property
//        }

//        int price = 107;
//        public int Price
//        {
//            get { return price; } // automatic property read and write both
//            set { price = value; }
//        }
//    }
//        internal class properties
//        {
//            static void Main(string[] args)
//            {
//                Employee employee = new Employee();
//                employee.Id = 1;
//                employee.Name = "manya";
//                employee.Description = "Wipro";

//                Console.WriteLine($"Employee id : {employee.Id}");
//                Console.WriteLine($"Employee Name : {employee.Name}");
//                Console.WriteLine($"Employee Description : {employee.Description}");

//               Book book = new Book();
//            Console.WriteLine(book.Title);
//            Console.WriteLine(book.Price);
//            book.Price = 7878;
//            Console.WriteLine(book.Price);

//        }
//        }
//    }
