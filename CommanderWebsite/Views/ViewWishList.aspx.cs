using CommanderWebsite.Controllers;
using CommanderWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommanderWebsite.Views
{
    public partial class ViewWishList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(Request.QueryString["Product_ID"]);
                Label3.Text = Request.QueryString["Product_ID"];
                CommanderEDM db = new CommanderEDM();
                var myWishList = WishListController.GetWishListItems(Context.User.Identity.Name);
                var ds = myWishList.Where(c => c.Product_ID == id);
                rprtWishList.DataSource = ds;
                rprtWishList.DataBind();

                if (myWishList.Count != 0)
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
                    Response.Redirect("~/Views/ViewWishListEmpty");
                }

            }
            catch (Exception ex)
            {

                idf.Text = ex.ToString();
                // Response.Redirect("Default.aspx", false);
            }

        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {

           
            int id = int.Parse(Request.QueryString["Product_ID"]);
            
               
                CommanderEDM db = new CommanderEDM();
                var d = ProductsController.getByID2(id);
                var c = WishListController.getWishListItem(Context.User.Identity.Name);
                CartController.AddToCart(id, c.Quantity, d.Name, d.Price, Context.User.Identity.Name);
                var myCart = CartController.GetCartItems(Context.User.Identity.Name);
                Repeater rp = (Repeater)Page.Master.FindControl("rptr");
                rp.DataSource = myCart;
                rp.DataBind();
                WishListController.removeItem(id, Context.User.Identity.Name);
                var myWishList = WishListController.GetWishListItems(Context.User.Identity.Name);
                HttpContext.Current.Session["WishListCount"] = myWishList.Count;
                HttpContext.Current.Session["CartCount"] = myCart.Count;
                Repeater rp1 = (Repeater)Page.Master.FindControl("Repeater1");
                rp1.DataSource = myWishList;
                rp1.DataBind();
                if(myWishList.Count ==0)
                {

                    Response.Redirect("~/Views/ViewWishListEmpty");
                }
                else
                {
                    Response.Redirect("~/");
                }
           
             }
            catch (Exception ex)
            {
                idf.Text = ex.ToString();
            }
        }

        protected void rem_Click(object sender, EventArgs e)
        {
            try
            {
                CommanderEDM _db = new CommanderEDM();
                int idLb = int.Parse(Label3.Text);
                WishListController.removeItem(idLb, Context.User.Identity.Name);
                var mywishlist = WishListController.GetWishListItems(Context.User.Identity.Name);
                Session["WishListCount"] = mywishlist.Count;
                var mycart = CartController.GetCartItems(Context.User.Identity.Name);
                HttpContext.Current.Session["CartCount"] = mycart.Count;
                if (mywishlist.Count == 0)
                {
                    Response.Redirect("~/Views/ViewWishListEmpty");
                }
                else
                {
                    Response.Redirect("~/");
                }

            }
            catch (Exception ex)
            {
                idf.Text = ex.ToString();
            }
        }



    }
}