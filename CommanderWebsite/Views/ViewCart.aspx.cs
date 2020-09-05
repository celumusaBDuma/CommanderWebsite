using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using CommanderWebsite.Models;
using CommanderWebsite.Controllers;

namespace CommanderWebsite.Views
{
    public partial class ViewCart : System.Web.UI.Page
    {
        DataTable myCart = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            
                
                    try
                    {
               

                CommanderEDM db = new CommanderEDM();
                var myCart = CartController.GetCartItems();
                HttpContext.Current.Session["CartCount"] = myCart.Count;
                        rprtCart.DataSource = myCart;
                        rprtCart.DataBind();
                
                        if (myCart.Count != 0)
                        {
                            var ed = myCart.Select(c => c.Product_ID);
                            int f = int.Parse(ed.ToString());
                             var dataT = ProductsController.getByID2(f);
                            if (dataT.Picture != null)
                            {
                                byte[] imageData = (byte[])dataT.Picture;
                                string img = Convert.ToBase64String(imageData, 0, imageData.Length);
                                imsdf.ImageUrl = "data:image/png;base64," + img;

                            }
                            else
                            {
                                imsdf.ImageUrl = "~/Content/Images/noImage.png";
                            }
                        }
                        else
                        {
                            Response.Redirect("~/Views/ViewCartEmpty.aspx", false);
                        }
                        
                    }
                    catch (Exception ex)
                    {

                        idf.Text = ex.ToString();
                       // Response.Redirect("Default.aspx", false);
                    }
                
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/CheckOut.aspx", false);
        }

        protected void rem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            ShoppingCart.makeCart(dt);
            Session["cart"] = dt;
            Session["CartCount"] = 0;
            Response.Redirect("~/Views/ViewCartEmpty.aspx",false);
        }



    }
}