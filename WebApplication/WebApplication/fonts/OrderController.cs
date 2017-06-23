using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
        public class SearchCondition
        {
            public int? CustomerID { get; set; }
        }
        public JsonResult Search(SearchCondition sc)
        {
            Models.CustomerService CustomerService = new Models.CustomerService();
            List<Models.Customers> customers = CustomerService.GetOrderByCondition(sc);
            List<Object> results = new List<Object>();
            for (int i = 0; i < customers.Count; i++)
            {
                Models.Customers order = customers[i];
                results.Add(new
                {
                    CustomerID = order.CustomerID,
                });
            }
            return Json(results, JsonRequestBehavior.AllowGet);
        }
    }
}