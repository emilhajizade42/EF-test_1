using ConsoleApp1.Controller;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
            var group = new EmployeeControl();
            group.CreateEmployee("RASHAD HAJIZADE", "MASTER");
            group.EditEmploye(2, "Eflatun");
            group.DeleteEmployee(1);
            foreach (var item in group.GetAllEmployee())
            {
                Console.WriteLine(item.Id + " " + item.Fullname+" "+ item.Position);
            }

        }
    }
}
