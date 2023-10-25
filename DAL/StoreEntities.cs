using DAL.Configurations;
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StoreEntities : DbContext
    {
        public StoreEntities() : base("DefaultConnection") { }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Request> Requests { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
        }
    }
}
