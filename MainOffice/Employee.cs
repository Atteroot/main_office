using System.Collections.Generic;
using System.Linq;

namespace MainOffice
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Employee(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }

        public Employee()
        {
        }
    }
}
