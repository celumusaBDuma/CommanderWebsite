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
        protected void Page_Load(object sender, EventArgs e)
        {             
                    try
                    {

                int id = int.Parse(Request.QueryString["Product_ID"]);
                Label3.Text = Request.QueryString["Product_ID"];
                CommanderEDM db = new CommanderEDM();
                var myCart = CartController.GetCartItems(Context.User.Identity.Name);
                var ds = myCart.Where(c => c.Product_ID == id);
                        rprtCart.DataSource = ds;
                        rprtCart.DataBind();
                
                        if (myCart.Count != 0)
                        {
                            
                             var dataT = ProductsController.getByID2(id);
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
                            Response.Redirect("~/Views/ViewCartEmpty");
                        }
                        
                    }
                    catch (Exception ex)
                    {

                        idf.Text = ex.ToString();
                       // Response.Redirect("Default.aspx", false);
                    }
                
        }

        protected void btnAddToWishList_Click(object sender, EventArgs e)
        {
            try
            {


                int id = int.Parse(Request.QueryString["Product_ID"]);


                CommanderEDM db = new CommanderEDM();
                var d = ProductsController.getByID2(id);
                var ds = db.Carts.SingleOrDefault(c=> c.Product_ID == id);
                int f = (int)ds.Quantity;
                WishListController.AddToWishList(id, f, d.Name, d.Price, Context.User.Identity.Name);
                var myWishList = WishListController.GetWishListItems(Context.User.Identity.Name);
                
                Repeater rp = (Repeater)Page.Master.FindControl("Repeater1");
                rp.DataSource = myWishList;
                rp.DataBind();
                CartController.removeItem(id, Context.User.Identity.Name);
                var myCart = CartController.GetCartItems(Context.User.Identity.Name);
                HttpContext.Current.Session["CartCount"] = myCart.Count;
                HttpContext.Current.Session["WishListCount"] = myWishList.Count;
                Repeater rp1 = (Repeater)Page.Master.FindControl("rptr");
                rp1.DataSource = myCart;
                rp1.DataBind();
                if (myCart.Count == 0)
                {

                    Response.Redirect("~/Views/ViewCartEmpty",false);
                }
                else
                {
                    Response.Redirect("~/", false);
                }

            }
            catch (Exception ex)
            {
                idf.Text = ex.ToString();
            }
        }

        protected void btnCheckout_Click(object sender, EventArgs e)
        {
            if (Context.User.IsInRole("Customer"))
            { 
                int id = int.Parse(Request.QueryString["Product_ID"]);
                Response.Redirect("~/Views/CheckOut?Product_ID="+ id);
            }
            else
            {
                idf.Text = "Sorry, only customers can checkout at the moment";
            }
        }

        protected void rem_Click(object sender, EventArgs e)
        {
            try
            { 
                CommanderEDM _db = new CommanderEDM();
                int idLb = int.Parse(Label3.Text);
                CartController.removeItem(idLb, Context.User.Identity.Name);
                var mycart = CartController.GetCartItems(Context.User.Identity.Name);
                Session["CartCount"] = mycart.Count;
                if(mycart.Count == 0) { 
                    Response.Redirect("~/Views/ViewCartEmpty");
                }
                else
                {
                    Response.Redirect("~/");
                }
                
            }
            catch(Exception ex)
            {
                idf.Text = ex.ToString();
            }
        }



    }
}