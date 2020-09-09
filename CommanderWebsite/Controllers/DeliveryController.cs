using CommanderWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommanderWebsite.Controllers
{
    public class DeliveryController
    {
        public static void InsertDelivery(string address, string user)
        {
            CommanderEDM db = new CommanderEDM();
            var userRow = CustomerController.FindByEmail(user);
            int id = int.Parse(userRow.Customer_ID.ToString());
            var deliver = new Delivery()
            {
                Admin_ID = 1,
                dAddress = address,
                Cost = 20,
                Delivered = 0,
                Customer_ID = id
            };
            db.Deliveries.Add(deliver);
            db.SaveChanges();
        }

        public static int getLastID(string user)
        {
            CommanderEDM db = new CommanderEDM();
            var cust = CustomerController.FindByEmail(user);
            var d = db.Deliveries.Where(c => c.Customer_ID == cust.Customer_ID).OrderByDescending(c => c.Delivery_ID).FirstOrDefault();
            var id = int.Parse(d.Delivery_ID.ToString());
            return id;
        }
    }
}