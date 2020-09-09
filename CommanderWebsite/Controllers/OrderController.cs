using CommanderWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommanderWebsite.Controllers
{
    public class OrderController
    {
        public static void InsertOrder(string user, int? prodID, int? pay, int? del, decimal? price)
        {
            CommanderEDM db = new CommanderEDM();
            var userRow = CustomerController.FindByEmail(user);
            int id = int.Parse(userRow.Customer_ID.ToString());
            var order = new Order()
            {
                Product_ID = prodID,
                Customer_ID = id,
                Payment_ID = pay,
                Date = DateTime.Now,
                Delivery_ID = del,
                Final_Price = price,
                IsReturned = 0
            };
            db.Orders.Add(order);
            db.SaveChanges();
        }

        public static int getOrderID(string user)
        {
            CommanderEDM db = new CommanderEDM();
            var cust = CustomerController.FindByEmail(user);
            var d = db.Orders.Where(c => c.Customer_ID ==cust.Customer_ID).OrderByDescending(c => c.Order_ID).FirstOrDefault();
            var id = int.Parse(d.Order_ID.ToString());
            return id;
        }

        public static List<Order> getOrderID(int id)
        {
            CommanderEDM db = new CommanderEDM();
            var order = db.Orders.Where(c => c.Order_ID == id).ToList();
            return order;
        }

        public static Order getOrder(int id)
        {
            CommanderEDM db = new CommanderEDM();
            var order = db.Orders.SingleOrDefault(c => c.Order_ID == id);
            return order;
        }

        public static IEnumerable<Order> getByCatID4(int id, int cus)
        {
            CommanderEDM db = new CommanderEDM();
            var prod = db.Orders.Select(c => c).ToList();
            var prodi = prod.Where(c => c.Customer_ID == cus);
            return prodi;
        }

        public static IEnumerable<Order> getByCatID3( int cus)
        {
            CommanderEDM db = new CommanderEDM();
            var prod = db.Orders.Select(c => c).ToList();
            var prodi = prod.Where(c => c.Customer_ID == cus && c.Product.Product_ID == c.Product_ID);
            return prodi;
        }

    }
}