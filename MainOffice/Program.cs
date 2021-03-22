using NLog;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MainOffice
{
    class Program
    {
        static void Main(string[] args)
        {

            var employeeService = new EmployeeService();

            Console.WriteLine(Resource.AddEmployee);
            employeeService.Add(new Employee(1, "Oleg", "Zhevanov"));
            Console.WriteLine(Resource.AddEmployee);
            employeeService.Add(new Employee(2, "Sasha", "Bagma"));
            Console.WriteLine(Resource.AddEmployee);
            employeeService.Add(new Employee(3, "Sasha", "Levchenko"));
            Console.WriteLine(Resource.AddEmployee);
            employeeService.Add(new Employee(4, "Alex", "Navroskiy"));

            Console.WriteLine(Resource.RemoveEmployee);
            employeeService.Remove("Alex");

            MainOfficeDataContext db = new MainOfficeDataContext();
            db.Employees.AddRange(employeeService.Employees);
            db.SaveChanges();
        }
    }
}
