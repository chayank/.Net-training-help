using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using trainingcheck.Models;


namespace trainingcheck.Controllers
{
    public class GraphsController : Controller
    {
        UserManager manager = new UserManager();

        // GET: Graphs
        public ActionResult Index()
        {
           
            //pass your stock to sid 
            int sid = 1061;
            ViewBag.sid = sid;
            //

            ViewBag.sname = manager.StpDBEntities.tblStocks.Find(sid).stockName.ToString();
            List<DataPoint> dataPoints = new List<DataPoint>();
            var temp = manager.StpDBEntities.tblStocksPrices.Where(t => t.stockId == sid).OrderByDescending(p => p.timeOfDay).Take(10); 
            foreach (var stk in manager.StpDBEntities.tblStocksPrices.Where(t => t.stockId == sid).OrderByDescending(p => p.id).Take(10).OrderBy(p=>p.id))
            {
                
                System.Diagnostics.Debug.WriteLine("{0} {1}",stk.currentPrice,stk.timeOfDay);

                dataPoints.Add(new DataPoint(stk.timeOfDay.ToString(), stk.currentPrice.Value));
            }



            
            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);

         


            return View();
        }


        public ContentResult JSON(int sid)
        {
            

            List<DataPoint> dataPoints = new List<DataPoint>();
            var temp = manager.StpDBEntities.tblStocksPrices.Where(x => x.stockId == sid).OrderByDescending(p => p.id).Take(1);
           
            foreach(var y in temp)
            {
                dataPoints.Add(new DataPoint(y.timeOfDay.ToString(), y.currentPrice.Value));
            }
            return Content(JsonConvert.SerializeObject(dataPoints, _jsonSetting), "application/json");
        }

        JsonSerializerSettings _jsonSetting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };

    }
}