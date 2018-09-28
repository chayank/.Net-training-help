using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
   

    public class StronglyTypedController : Controller
    {
        // GET: StronglyTyped
        public ActionResult Index()
        {
            Employee e = new Employee { id = 5, name = "kiran", salary = 23003 };
            return View(e);
        }


        public ActionResult ListOfEmployees()
        {
            List<Employee> es = Employee.employees;
            return View(es);
        }

        public ActionResult details(int id)
        {
            Employee e = Employee.employees.Single(x => x.id == id);

            return View(e);
        }
    }
}