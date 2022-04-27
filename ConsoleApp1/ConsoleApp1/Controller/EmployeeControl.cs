using ConsoleApp1.DataAccess;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Controller
{
    public class EmployeeControl
    {
        private readonly AddDbContex contex;

        public EmployeeControl()
        {
            contex = new AddDbContex();
        }

        public List<Employee> GetAllEmployee()
        {
            return contex.Employees.ToList();
        }

        public void CreateEmployee(string name , string position)
        {
            Employee employee = new Employee { Fullname=name , Position=position};
            contex.Employees.Add(employee);
            contex.SaveChanges();
        }


        public void EditEmploye(int id , string name)
        {
            Employee employee = contex.Employees.Find(id);
            
            employee.Fullname = name;

            contex.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            Employee employee = contex.Employees.Find(id);
            contex.Employees.Remove(employee);
            contex.SaveChanges();
        }
    }
}
