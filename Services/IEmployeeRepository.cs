﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Infrastructure;
using Models;

namespace Services
{
    public interface IEmployeeRepository : IRepository<Employee>    
    {
    }
}
