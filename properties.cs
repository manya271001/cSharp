using System;


namespace ConsoleApp1WiproTraining
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
    }
    internal class properties
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "manya";
            employee.Description = "Wipro";

            Console.WriteLine($"Employee id : {employee.Id}");
            Console.WriteLine($"Employee Name : {employee.Name}");
            Console.WriteLine($"Employee Description : {employee.Description}");
        }
    }
}
