using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class RequestConfiguration: EntityTypeConfiguration<Request>
    {
        public RequestConfiguration()
        {
            ToTable("Requests");
            HasKey(u => u.RequestID);
        }
    }
}
