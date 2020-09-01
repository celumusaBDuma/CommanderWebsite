using CommanderWebsite.Controllers;
using CommanderWebsite.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CommanderWebsite
{
    public class ShoppingCart
    {
        public static DataTable cart { get; set; }

        public static DataTable makeCart(DataTable myCart)
        {
            myCart.Columns.Add("PackageID");
            myCart.Columns.Add("PackageName");
            myCart.Columns.Add("PackageType");
            myCart.Columns.Add("PackageSize");
            myCart.Columns.Add("PackageCount");
            myCart.Columns.Add("PackageCost");
            cart = myCart;
            return myCart;
        }

        public static int CheckCart(DataTable myCart, int CheckID)
        {
            for (int i = 0; i < myCart.Rows.Count; i++)
            {
                int s = (int)myCart.Rows[i]["PackageID"];
                if (s == CheckID)
                {
                    return i;
                }
            }
            return 0;
        }

        public static DataTable NewRowCart(DataTable myCart, int ID, string name, string type, int count, decimal? cost)
        {
            CommanderEDM db = new CommanderEDM();
            DataTable datat = new DataTable();
            var d = ProductsController.getByID(ID);
            cart = myCart;
            DataRow Cartrow = cart.NewRow();
            Cartrow["PackageID"] = d.Product_ID;
            Cartrow["PackageName"] = d.Name;
            Cartrow["PackageType"] = d.Type;
            Cartrow["PackageSize"] = d.size;
            Cartrow["PackageCount"] = d.Quantity;
            Cartrow["PackageCost"] = d.Price;
            cart.Rows.Add(Cartrow);
            return cart;
        }
    }
}