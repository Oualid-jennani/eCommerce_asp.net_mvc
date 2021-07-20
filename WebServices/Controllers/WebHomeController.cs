using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebServices.localhost;

namespace WebServices.Controllers
{
    public class WebHomeController : Controller
    {
        // GET: WebHome
        public ActionResult Index()
        {
            WebService1 ws = new WebService1();
            ViewBag.fu1 = ws.GetCurrentDayRevenue();

            ViewBag.fu3 = ws.GetBestSellingProduct();

            ViewBag.fu4 = ws.GetTopFiveClients();
            return View();
        }

        [HttpPost]
        public ActionResult Index(DateTime dt)
        {

            WebService1 ws = new WebService1();

            ViewBag.fu1 = ws.GetCurrentDayRevenue();

            DateTime dt1 = DateTime.Parse(Request.Params.Get("dt1"));
            DateTime dt2 = DateTime.Parse(Request.Params.Get("dt2"));
            ViewBag.fu2 = ws.GetRevenueByPeriod(dt1, dt2);

            ViewBag.fu3 = ws.GetBestSellingProduct();

            ViewBag.fu4 = ws.GetTopFiveClients();

           


            return View();
        }

    }



}