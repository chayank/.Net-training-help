using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class GuestController : Controller
    {
        // GET: Guest
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(string uname,string pass)
        {
            StpDBEntities db = new StpDBEntities();
            tblUser user = db.tblUsers.SingleOrDefault(x => x.fname==uname && x.lname==pass);
            if (user != null)
            {
                Session["uname"] = uname;
                return RedirectToAction("dashboard");
            }
            else
            {
                ViewBag.msg = "invalid input credentials";
            }
            return View();
        }

        public ActionResult DashBoard()
        {
            if (Session["uname"] != null)
            {
                string uname = Session["uname"].ToString();
                ViewBag.msg = "hello" + uname + ",welcome";
            }
            return View();
        }
        [HttpPost]
        public ActionResult DashBoard(string bp)
        {
            return RedirectToAction(bp);
        }


        public ActionResult Confidential()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Confidential(string bp)
        {
            return RedirectToAction(bp);
        }
        public ActionResult Logout()
        {
            return View();
        }
    }
}