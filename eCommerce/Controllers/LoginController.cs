using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace eCommerce.Controllers
{
    public class LoginController : Controller
    {
        public eComEntities Ec = new eComEntities();
        // GET: Login
        public ActionResult Index()
        {
            if (Request.Params.Get("dec") == "1")
            {
                Session["User"] = null;
            }
            if (Request.Params.Get("name") !=null && Request.Params.Get("name") != "" && Request.Params.Get("pass") != null && Request.Params.Get("pass") != "")
            {

                foreach (User u in Ec.User.ToList())
                {
                    if (u.login.ToString() == Request.Params.Get("name").ToString())
                    {
                        if (u.passwordd.ToString() == FormsAuthentication.HashPasswordForStoringInConfigFile(Request.Params.Get("pass").ToString(), "SHA1").ToString())
                        {
                            Session["user"] = Request.Params.Get("name");

                            Response.Redirect("/Products/Index");
                        }
                    }
                }

            }
            return View();
        }
    }
}