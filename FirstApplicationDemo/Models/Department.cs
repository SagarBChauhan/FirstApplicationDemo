using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace FirstApplicationDemo.Models
{
    [Table("tblDepartment")]
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public DbSet<Employee> employee { get; set; }
    }
}