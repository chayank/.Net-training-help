using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class PostBackDemosController : Controller
    {
        // GET: PostBackDemos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ex1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ex1(string ename)
        {
            ViewBag.msg = "hello" + ename;
            return View();
        }



        public ActionResult Ex2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ex2(string b1)
        {
            ViewBag.msg = b1;
            return View();
        }


        public ActionResult Ex3()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ex3(string b1,int y,int x)
        {
            if (b1.Equals("add"))
            {
                ViewBag.msg = "addition : = " + (x + y);
            }
            else
            {
                ViewBag.msg = "subtraction : = " + (x - y);
            }
            return View();
        }



        public ActionResult Ex4()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ex4(string name, string gender)
        {
            ViewBag.msg = "hello: " + gender + name;
            return View();
        }


        public ActionResult Ex5()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ex5(string name, string check)
        {
            ViewBag.msg = "hello: " + name+" you have "+check+" checked";
            return View();
        }


        public ActionResult Ex6()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ex6(string name, string[] check)
        {
            ViewBag.msg = "hello: " + name + " you have these : ";

            string msg = string.Empty;
            foreach (string s in check)
            {
                if (!s.Equals("false"))
                {
                    msg += s+"<br/>";
                }
            }
            ViewBag.msg = msg;
            return View();
        }


        public ActionResult Ex8()
        {
            List<string> op = new List<string> { "update", "delete", "retrieve" };
            TempData["op"] = op;
            return View();
        }
        [HttpPost]
        public ActionResult Ex8(string op)
        {

            ViewBag.msg = op;
            return View();
        }

        public ActionResult Ex9()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Ex9(string b1)
        {

           
                return RedirectToAction(b1);
          
        }
    }
}