using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class StpDbController : Controller
    {

        static StpDBEntities e = new StpDBEntities();
        // GET: StpDb
        public ActionResult Index()
        {
            return View(e.tblUsers);
        }

        public ActionResult details(int id)
        {
            return View(e.tblUsers.Single(x=>x.uid==id));
        }

        public ActionResult edit(int id)
        {
            return View(e.tblUsers.Single(x => x.uid == id));
        }
        [HttpPost]
        public ActionResult edit(tblUser u)
        {


            tblUser s = e.tblUsers.Single(x => x.uid == u.uid);
            s = u;
            e.SaveChanges();

            return RedirectToAction("Index");
        }
        //have to creat a post type as weell
        public ActionResult delete(int id)
        {
            return View(e.tblUsers.Single(x => x.uid == id));
        }
        

        public ActionResult create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult create(tblUser e1)
        {
            e.tblUsers.Add(e1);
            e.SaveChanges();
            return RedirectToAction("index");
        }
    }
}