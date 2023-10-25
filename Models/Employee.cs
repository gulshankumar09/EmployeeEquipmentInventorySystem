using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeDapartMent { get; set; }

        public Request Request { get; set; }
    }
}
