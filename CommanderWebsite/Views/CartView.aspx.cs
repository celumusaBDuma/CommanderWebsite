using CommanderWebsite.Controllers;
using CommanderWebsite.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommanderWebsite.Views
{
    public partial class CartView : System.Web.UI.Page
    {
        DataTable myCart = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

            myCart = (DataTable)Session["cart"];

            try
            {

                CommanderEDM db = new CommanderEDM();
                DataTable dt = myCart;
                rprtCart.DataSource = dt;
                rprtCart.DataBind();
                Image imgf = (Image)Page.Master.FindControl("imsf");
                if (myCart.Rows.Count != 0)
                {
                    int f = int.Parse(myCart.Rows[0]["PackageID"].ToString());
                 /*   var dataT = ProductsController.getByID(f);
                    if (dataT.Picture != null)
                    {
                        byte[] imageData = (byte[])dataT.Picture;
                        
                        string imgd = Convert.ToBase64String(imageData, 0, imageData.Length);
                        imgf.ImageUrl = "data:image/png;base64," + imgd;

                    }
                    else
                    {
                        imgf.ImageUrl = "Resources/noImage.png";
                    }*/
                }
                else
                {
                    Response.Redirect("/ViewCartEmpty.aspx", false);
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
            //Response.Redirect("/Restricted Access/Customer/CheckOut.aspx", false);
        }

        protected void rem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            ShoppingCart.makeCart(dt);
            Session["cart"] = dt;
            Session["count"] = 0;
            //Response.Redirect("/ViewCartEmpty.aspx", false);
        }

    }
}