using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL.Configurations
{
    public class EmployeeConfiguration :EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            ToTable("Employees");
            HasKey(u => u.EmployeeID);
            Property(u => u.EmployeeFirstName).IsRequired().HasMaxLength(50);
            Property(u => u.EmployeeLastName).IsRequired().HasMaxLength(50);
        }
    }
}
