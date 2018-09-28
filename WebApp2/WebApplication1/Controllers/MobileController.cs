using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MobileController : Controller
    {
        // GET: Mobile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sales()
        {
            return View();
        }

        public ActionResult Service()
        {
            return View();
        }
    }
}