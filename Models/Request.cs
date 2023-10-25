using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Request
    {
        public int RequestID { get; set; }
        public int MyProperty { get; set; }
        public DateTime RequestDate { get; set; }

        public Request()
        {
            this.RequestDate = DateTime.Now;
        }
        public int EmployeeID { get; set; }
        public virtual IEnumerable<Employee> Employees { get; set; }
    }
}
