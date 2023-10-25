using DAL;
using DAL.Infrastructure;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Services
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {

        public EmployeeRepository(StoreEntities storeEntities): base(storeEntities)
        {
          
        }

      
    }
}
