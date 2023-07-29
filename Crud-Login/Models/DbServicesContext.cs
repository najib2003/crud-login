using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Crud_Login.Models
{
    public class DbServicesContext : DbContext
    {
        public DbSet<Employee> tbl_emp { get; set; }
    }
}