using CommanderWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommanderWebsite.Controllers
{
    public class ProductsController
    {
        public static Product getByID(int prodID)
        {
            CommanderEDM db = new CommanderEDM();
            var prod = db.Products.SingleOrDefault(c => c.Product_ID == prodID);
            return prod;
        }

        public static List<Product> GetProducts()
        {
            var _db = new CommanderEDM();
            var prod =  _db.Products.Select(c => c).ToList();
            return prod;
        }

      /* public static byte[] getByImg(int img)
        {
            var _db = new CommanderEDM();
            var full = _db.Products.SingleOrDefault(c => c.Product_ID == img).Picture;

            return full;
        } */
    }
}