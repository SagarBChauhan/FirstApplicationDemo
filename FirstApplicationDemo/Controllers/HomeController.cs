using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApplicationDemo.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string Id,string name)
        {
            return "Id=" + Id + "name=" + name;
        }

        public ActionResult Details(string Name, string Sem)
        {
            ViewBag.Name = Name;
            ViewData["Sem"] = Sem;
            ViewBag.Cities = new List<string>()
            {
                "surat",
                "vadodara"
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
