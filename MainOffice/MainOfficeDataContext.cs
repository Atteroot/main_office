using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainOffice
{
    class MainOfficeDataContext :DbContext
    {
        public MainOfficeDataContext()
           : base("DbConnection")
        { }

        public DbSet<Employee> Employees { get; set; }
    }
}
