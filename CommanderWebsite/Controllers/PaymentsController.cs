using CommanderWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommanderWebsite.Controllers
{
    public class PaymentsController
    {
        public static void InsertPayment(string user, decimal? due)
        {
            CommanderEDM db = new CommanderEDM();
            var userRow = CustomerController.FindByEmail(user);
            int id = int.Parse(userRow.Customer_ID.ToString());
            var payment = new Payment()
            {
                Date = DateTime.Now,
                Customer_ID = id,
                AmountDue = due,
                Payed = 0  //Either 0 or 1, if 0 not payed
            };
            db.Payments.Add(payment);
            db.SaveChanges();
        }

        public static int LastPay(string user) //I'll finish this later
        {
            CommanderEDM db = new CommanderEDM();
            var cust = CustomerController.FindByEmail(user);
            var d = db.Payments.Where(c=> c.Customer_ID == cust.Customer_ID).OrderByDescending(c => c.Payment_ID).FirstOrDefault();
            var id = int.Parse(d.Payment_ID.ToString());
            return id;
        }
    }
}