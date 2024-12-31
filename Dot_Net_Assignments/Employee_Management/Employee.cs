using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethos
{
    internal class Employee
    {
        public string EmpName;
        public int EmployeeID;
        public string EmpDesignation;

        public Employee(string name, int id, string desig)
        {
            this.EmpName = name;
            this.EmployeeID = id;
            this.EmpDesignation = desig;
        }
    }
}
