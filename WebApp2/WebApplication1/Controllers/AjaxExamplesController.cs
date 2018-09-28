using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class Person
    {
        public int Pid { get; set; }
        public string PName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

       public static List<Person> people;

        public static List<Person> GetPeople()
        {
            people = new List<Person>()
            {
                new Person(){Pid=1001,PName="Kiran",Gender="Male",Age=33},
new Person(){Pid=1002,PName="Sameera",Gender="Female",Age=23},
new Person(){Pid=1003,PName="Sarika",Gender="Female",Age=23},
new Person(){Pid=1004,PName="Swathi",Gender="Female",Age=31},
new Person(){Pid=1005,PName="Ashok",Gender="Male",Age=21},
new Person(){Pid=1006,PName="Suresh",Gender="Male",Age=25}
            };
            return people;
        }
    }

   
    public class AjaxExamplesController : Controller
    {
        public static List<Person> p;

        // GET: AjaxExamples
        public ActionResult Index()
        {
            return View();
        }

        public string GetServerTime()
        {
            return DateTime.Now.ToLongTimeString();
        }


        public PartialViewResult AllPeople()
        {
            p = Person.GetPeople();
            return PartialView("_AllPeople",p);
        }
        public PartialViewResult MalePeople()
        {
            p = Person.GetPeople().Where(x => x.Gender == "Male").ToList();
            return PartialView("_AllPeople", p);
        }
        public PartialViewResult FemalePeople()
        {
            p = Person.GetPeople().Where(x => x.Gender == "Female").ToList();
            return PartialView("_AllPeople", p);
        }



    }
}