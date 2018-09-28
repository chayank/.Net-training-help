using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public string posting { get; set; }
        public static List<Employee> employees =new  List<Employee>
                {new Employee{id=1,name="chayank",salary=2000 ,posting="trainer"},
                new Employee{id=2,name="prajjwal",salary=2000 ,posting="devop"},
                 new Employee{id=3,name="arihant",salary=2000 ,posting="tester"},

        };
          
       
    }
        public class HomeController : Controller
        {

            // GET: Home
            public ActionResult web()
            {
                ViewBag.msg = "welcome to  home";
                return View();
            }
        // GET: Home
        public ActionResult Index()
            {
                ViewBag.msg = "welcome to  home";
                return View();
            }

        [HttpPost]
        public ActionResult Index(string id)
        {
            ViewBag.msg = "hello , welcome back";
            return View();
        }
        public string ContactUs()
            {
                return "you can reach us at rtrt@disj.com";
            }

            public ActionResult Facilities()
            {
                return View();
            }
            public ActionResult Practice()
            {
                return View();
            }

            public ActionResult PracticeEx2()
            {
                return View();
            }

            public ActionResult PracticeEx3()
            {
                return View();
            }


            public ActionResult PracticeEx4()
            {
                return View();
            }

            public ActionResult PracticeEx5()
            {
                return View();
            }

            public ActionResult PracticeEx6()
            {
                return View();
            }

            public ActionResult PracticeEx7()
            {
                ViewData["name"] = "chayank";
                ViewData["city"] = "BLR";
                return View();
            }

            public ActionResult PracticeEx8()
            {
                ViewBag.name = "chayank";
                ViewBag.city = "BLR";
                return View();
            }

            public ActionResult PracticeEx9()
            {
                string[] s = { "chayank", "prajwal", "akash" };
                ViewBag.names = s;
                ViewBag.city = "BLR";
                return View();
            }

            public ActionResult PracticeEx10()
            {
                List<string> s = new List<string> { "chayank", "prajwal", "akash" };
                ViewBag.names = s;
                ViewBag.city = "BLR";
                return View();
            }

            public ActionResult PracticeEx11()
            {
                List<Employee> s = Employee.employees;
                ViewBag.names = s;
                ViewBag.city = "BLR";
                return View();
            }

        public ActionResult details(int id)
        {
            ViewBag.e = Employee.employees.SingleOrDefault(x => x.id == id);
            return View();
        }

        public ActionResult  Create()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Create(int id1, string name1, int salary1)
        {
            Employee e = new Employee { id = id1, name = name1, salary = salary1,posting="deveop" };
            Employee.employees.Add(e);
            
            return RedirectToAction("PracticeEx11");
        }



    }
}
