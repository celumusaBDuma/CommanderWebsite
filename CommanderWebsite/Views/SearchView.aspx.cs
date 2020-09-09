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
    public partial class SearchView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                try
                {
                    int id = int.Parse(Request.QueryString["Product_ID"]);

                    CommanderEDM db = new CommanderEDM();
                    var d1 = ProductsController.getByID1(id);
                    var d = ProductsController.getByID2(id);
                    rptrImages2.DataSource = d1;
                    rptrImages2.DataBind();
                    if (d.Picture != null)
                    {
                        byte[] imageData = (byte[])d.Picture;
                        string img = Convert.ToBase64String(imageData, 0, imageData.Length);
                        im.ImageUrl = "data:image/png;base64," + d.Picture;

                    }
                    else
                    {
                        im.ImageUrl = "~/Content/Images/noImage.png";
                    }


                }
                catch (Exception ex)
                {
                    Label1.Text = ex.ToString();
                    ///Response.Redirect("Packages.aspx", false);
                }
            }

        }



        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(Request.QueryString["Product_ID"]);
                if (Context.User.Identity.IsAuthenticated == true)
                {
                    CommanderEDM db = new CommanderEDM();
                    var d = ProductsController.getByID2(id);
                    DropDownList df = (DropDownList)Page.Master.FindControl("dl");
                    DropDownList df1 = (DropDownList)rptrImages2.Items[0].FindControl("DropDownList1");
                    CartController.AddToCart(id, int.Parse(df1.SelectedValue), d.Name, d.Price, Context.User.Identity.Name);
                    var myCart = CartController.GetCartItems(Context.User.Identity.Name);
                    HttpContext.Current.Session["CartCount"] = myCart.Count;
                    var myWishlist = WishListController.GetWishListItems(Context.User.Identity.Name);
                    HttpContext.Current.Session["WishListCount"] = myWishlist.Count;
                    Repeater rp = (Repeater)Page.Master.FindControl("rptr");
                    rp.DataSource = myCart;
                    rp.DataBind();
                }
                else
                {
                    Response.Redirect("~/Account/Login?ReturnUrl=" + "~/Views/MensView?Product_ID=" + id);
                }
                }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
        }

             protected void btnAddToWishList_Click(object sender, EventArgs e)
        {
            try
            {


                int id = int.Parse(Request.QueryString["Product_ID"]);

                if (Context.User.Identity.IsAuthenticated == true)
                {
                    CommanderEDM db = new CommanderEDM();
                var d = ProductsController.getByID2(id);
                var ds = db.Carts.SingleOrDefault(c => c.Product_ID == id);
                int f = (int)ds.Quantity;
                WishListController.AddToWishList(id, f, d.Name, d.Price, Context.User.Identity.Name);
                var myWishList = WishListController.GetWishListItems(Context.User.Identity.Name);
                HttpContext.Current.Session["WishListCount"] = myWishList.Count;
                var mycart = CartController.GetCartItems(Context.User.Identity.Name);
                HttpContext.Current.Session["CartCount"] = mycart.Count;
                Repeater rp = (Repeater)Page.Master.FindControl("Repeater1");
                rp.DataSource = myWishList;
                rp.DataBind();
             
            }
            else
                {
                Response.Redirect("~/Account/Login?ReturnUrl=" + "~/Views/MensView?Product_ID=" + id);
            }

        }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
        }
    }
    
}