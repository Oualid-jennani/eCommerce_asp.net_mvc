 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Controllers
{
    public class ShopWalidController : Controller
    {
        public eComEntities Ec = new eComEntities();

        public static Product p = new Product();

        public static List<Product> Panier = new List<Product>();

        // GET: Home
        //***********************************************************************************************
        public ActionResult Home()
        {

            
            if(Request.Params.Get("category")!=null && Request.Params.Get("category") != "")
            {
                
                string name = Request.Params.Get("category");
                //List<Product> P = new List<Product>(Ec.Product.Where(p => p.Category.name == name));
                var P = Ec.Product.Where(p => p.Category.name == name);
                ViewBag.Pruduit = P;
            }
            else
            {
                ViewBag.Pruduit = Ec.Product;
            }

            
            return View();
        }
        //***********************************************************************************************
        public ActionResult About()
        {
            return View();
        }
        //***********************************************************************************************
        public ActionResult Contact()
        {
            return View();
        }
        //***********************************************************************************************
        public ActionResult details()
        {
            if(Request.Params.Get("IDproduit")!=null && Request.Params.Get("IDproduit") != "")
            {
                 p = Ec.Product.Find(int.Parse(Request.Params.Get("IDproduit")));
            }
            ViewBag.details = p;


            if (Request.Params.Get("Panier") == "true")
            {
                Panier.Add(p);
                Response.Redirect("/ShopWalid/Home");
            }

            return View();
        }

        //***********************************************************************************************
        public ActionResult panier()
        {
            if (Request.Params.Get("Confirm") == "true")
            {
                foreach(Product p in Panier)
                {

                    ProductOrder or = new ProductOrder();
                    or.productId = p.id;

                    Ec.ProductOrder.Add(or);
                }

                Response.Redirect("/ShopWalid/Home");
            }


            ViewBag.listPanier = Panier;
            return View();
        }
    }
}