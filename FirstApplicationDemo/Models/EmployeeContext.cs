using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FirstApplicationDemo.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> employee { get; set; }
        public DbSet<Department> department { get; set; }
    }
}