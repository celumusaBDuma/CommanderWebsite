using CommanderWebsite.Controllers;
using CommanderWebsite.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommanderWebsite.Views
{
    public partial class MensView : System.Web.UI.Page
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
                        im.ImageUrl = "data:image/png;base64," + img;

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


                    CommanderEDM db = new CommanderEDM();
                    var d = ProductsController.getByID2(id);
                    DropDownList df = (DropDownList)Page.Master.FindControl("dl");
                    DropDownList df1 = (DropDownList) rptrImages2.Items[0].FindControl("DropDownList1");
                    CartController.AddToCart(id, int.Parse(df1.SelectedValue),d.Name,d.Price);
                    var myCart = CartController.GetCartItems();
                    HttpContext.Current.Session["CartCount"] = myCart.Count;
                    Repeater rp = (Repeater)Page.Master.FindControl("rptr");
                    rp.DataSource = myCart;
                    rp.DataBind();
                
                

            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
        }



    }
}