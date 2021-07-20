using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace eCommerce
{
    /// <summary>
    /// Description résumée de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]

    public class WebService1 : System.Web.Services.WebService
    {
        public eComEntities Ec = new eComEntities();

        [WebMethod]
        public float GetCurrentDayRevenue()
        {
            float ChifrD = 0;
            try
            {
                ChifrD = float.Parse(Ec.ProductOrder.Where(c => c.Eorder.dateorder.Value.Day == DateTime.Now.Day).Sum(x => x.qt * x.Product.price).ToString());
            }
            catch (Exception ex)
            {

            }

            return ChifrD;
        }
        [WebMethod]
        public float GetRevenueByPeriod(DateTime startDate, DateTime endDate)
        {
            float ChifrD = 0;
            try
            {
                ChifrD = float.Parse(Ec.ProductOrder.Where(c => c.Eorder.dateorder > startDate && c.Eorder.dateorder < endDate).Sum(x => x.qt * x.Product.price).ToString());
            }
            catch (Exception ex)
            {

            }

            return ChifrD;
        }

        [WebMethod]

        public List<string> GetBestSellingProduct()
        {

            List<string> ProduitMax = new List<string>((Ec.Product.Where(x => x.ProductOrder.Count() == (Ec.Product.Select(C => C.ProductOrder.Count()).Max()))).Select(x => x.name));
            return ProduitMax;
        }

        [WebMethod, ScriptMethod(ResponseFormat = ResponseFormat.Xml)]

        public List<TopClient> GetTopFiveClients()
        {
            var top5Client = (from c in Ec.client select new { Tot = (Ec.ProductOrder.Select(x => new { tot = (x.Product.price * x.qt), idC = x.Eorder.clientid })).Where(i => i.idC == c.id).Sum(s => s.tot), idC = c.id, Fname = c.lastName,Lname = c.lastName,F=c.phone,E=c.Email,AD=c.adress }).OrderBy(o => o.Tot).Take(5);


            var ListC = new List<TopClient>();
            foreach(var c in top5Client)
            {
                TopClient TC = new TopClient();
                TC.id = c.idC;
                TC.firstName = c.Fname;
                TC.phone = c.F;
                TC.Email = c.E;
                TC.adress = c.AD;
                ListC.Add(TC);
            }
            
            return ListC;
        }
        public partial class TopClient
        {
            public int id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string phone { get; set; }
            public string Email { get; set; }
            public string adress { get; set; }
        }

    }
}
