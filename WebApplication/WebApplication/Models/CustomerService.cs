using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static WebApplication.Controllers.OrderController;
namespace WebApplication.Models
{
    public class CustomerService
    {
        Model1 db = new Model1();
        public Models.Customers GetOrderById(int CustomerID)
        {
            return db.Customers.Where(x => x.CustomerID == CustomerID).FirstOrDefault();
        }
        public List<Models.Customers> GetOrderByCondition(SearchCondition sc)
        {

            return db.Customers
                    .Where(x => sc.CustomerID == null || x.CustomerID == sc.CustomerID)
                    .ToList();
        }
    }
    
}