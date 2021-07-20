using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    public class DashboardController : Controller
    {
        public eComEntities Ec = new eComEntities();
        // GET: Dashboard
        public ActionResult Index()
        {
            if (Session["user"] == null)
            {
                Response.Redirect("/Login/Index");
            }


            ViewBag.commandes = Ec.Eorder.Where(E => E.dateorder.Value.Day == DateTime.Now.Day).Count();

            ViewBag.CountCom = Ec.Eorder.Count();

            ViewBag.NbClient = Ec.client.Count();

            ViewBag.ChifrDFday = Ec.ProductOrder.Where(x => x.Eorder.dateorder.Value.Day == DateTime.Now.Day).Sum(i=>i.Product.price*i.qt);

            ViewBag.ChifrMonth = Ec.ProductOrder.Where(x => x.Eorder.dateorder.Value.Month == DateTime.Now.Month).Sum(i => i.Product.price * i.qt);

            ViewBag.Chifryear = Ec.ProductOrder.Sum(i => i.Product.price * i.qt);

            return View();
        }
    }
}