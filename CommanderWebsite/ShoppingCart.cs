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
            myCart.Columns.Add("Product_ID");
            myCart.Columns.Add("Name");
            myCart.Columns.Add("Type");
            myCart.Columns.Add("Size");
            myCart.Columns.Add("Quantity");
            myCart.Columns.Add("Price");
            cart = myCart;
            return myCart;
        }

        public static int CheckCart(DataTable myCart, int CheckID)
        {
            for (int i = 0; i < myCart.Rows.Count; i++)
            {
                int s = (int)myCart.Rows[i]["Product_ID"];
                if (s == CheckID)
                {
                    return i;
                }
            }
            return 0;
        }

        public static DataTable NewRowCart(DataTable myCart, int ID)
        {
            CommanderEDM db = new CommanderEDM();
            DataTable datat = new DataTable();
            var d = ProductsController.getByID(ID);
            cart = myCart;
            DataRow Cartrow = cart.NewRow();
            Cartrow["Product_ID"] = d.Product_ID;
            Cartrow["Name"] = d.Name;
            Cartrow["Type"] = d.Type;
            Cartrow["Size"] = d.size;
            Cartrow["Quantity"] = d.Quantity;
            Cartrow["Price"] = d.Price;
            cart.Rows.Add(Cartrow);
            return cart;
        }
    }
}