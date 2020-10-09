
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstApplicationDemo.Models;

namespace FirstApplicationDemo.Controllers
{
    public class DepartmentController : Controller
    {
        //
        // GET: /Department/
        EmployeeContext objEmployeeContext = new EmployeeContext();
        public ActionResult List()
        {
            List<Department> objDepartment = objEmployeeContext.department.ToList();
            return View(objDepartment);
        }

    }
}
