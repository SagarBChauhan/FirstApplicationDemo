using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstApplicationDemo.Models;

namespace FirstApplicationDemo.Controllers
{
    public class HtmlHelperController : Controller
    {
        //
        // GET: /HtmlHelper/
        EmployeeContext objConext = new EmployeeContext();
        public ActionResult Index()
        {
            ViewBag.Department = new SelectList(objConext.department, "DepartmentID", "DepartmentName");
            return View();
        }

    }
}
