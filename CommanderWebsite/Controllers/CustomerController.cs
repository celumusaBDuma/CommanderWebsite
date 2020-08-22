using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommanderWebsite.Models
{
    public class CustomerController : CommanderEDM
    {

        public static void AddCustomer(string firstName, string lastName, string email, string passWord)
        {
            using (var context = new CommanderEDM())
            {
                var newCustomer = new Customer()
                {
                    Firstname = firstName,
                    Lastname = lastName,
                    Email = email,
                    Password = passWord

                };
                context.Customers.Add(newCustomer);
                context.SaveChanges();
            }
        }

        /*   
         *   Update method
         *     private static void ChangeCustomer()
             {

                 using (var context = new CommanderEDM())
                 {

                     var customer = (from d in context.Customers
                                    where d.Firstname == "Ali"
                                    select d).Single();
                     customer.Lastname = "Aslam";
                     context.SaveChanges();

                 }
             }


          //Delete method beware of foreign keys 
          private static void DeleteCustomer() {

        using (var context = new CommanderEDM()) {
           var deleteCust = (from d in context.Customers where d.Firstname == "Ali" select d).Single();
           context.Students.Remove(deleteCust);
           context.SaveChanges();
        }
     }
         */

    }
}
      