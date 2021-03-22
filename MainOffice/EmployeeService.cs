using NLog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MainOffice
{
    class EmployeeService
    {
        public List<Employee> Employees { get; set; }

        public EmployeeService()
        {
            Employees = new List<Employee>();
        }

        public void Add(Employee employee)
        {
            Employees.Add(employee);
        }

        public void Remove(string name)
        {
            try
            {
                Employees.Remove(Employees.FirstOrDefault(x => x.Name == name));
            }
            catch(Exception exception)
            {
                LogManager.GetCurrentClassLogger().Error(exception.Message);
            }
        }
    }
}
