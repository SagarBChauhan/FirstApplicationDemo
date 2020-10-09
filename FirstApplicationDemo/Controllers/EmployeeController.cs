using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstApplicationDemo.Models;

namespace FirstApplicationDemo.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        EmployeeContext objEmployeeContext =
            new EmployeeContext();
        public ActionResult List(int DepartmentID)
        {
            List<Employee> objEmployee = 
                objEmployeeContext.
                employee.Where(emp => 
                    emp.DepartmentID == 
                    DepartmentID).ToList();
            return View(objEmployee);
        }
        public ActionResult Index(int Id)
        {
           /* Employee objEmployee = new Employee()
            {
                EmployeeID = 1,
                Name = "Jigna",
                Gender = "Female",
                City ="Surat"
            };*/
            
            Employee objEmployee = objEmployeeContext.
                employee.Single(emp => emp.EmployeeID == Id);

            return View(objEmployee);
        }

    }
}
