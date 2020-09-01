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
    public partial class MensView : System.Web.UI.Page
    {
        DataTable myCart = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            myCart = (DataTable)Session["cart"];

            if (!IsPostBack)
            {
                try
                {
                    int id = int.Parse(Request.QueryString["PackageID"]);

                    CommanderEDM db = new CommanderEDM();
                 //   var d = ProductsController.getByID(id);

                   // rptrImages2.DataSource = d;
                   // rptrImages2.DataBind();
                   
                   // if (d.Picture != null)
                   // {
                    //    byte[] imageData = (byte[])d.Picture;
                     //   string img = Convert.ToBase64String(imageData, 0, imageData.Length);
                     //   im.ImageUrl = "data:image/png;base64," + img;

//                    }
  //                  else
    //                {
      //                 /// im.ImageUrl = "Resources/noImage.png";
        //            }


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
                if (myCart.Rows.Count < 1)
                {
                    int id = int.Parse(Request.QueryString["PackageID"]);


                    CommanderEDM db = new CommanderEDM();
                    var d = ProductsController.getByID(id);
                    DropDownList df = (DropDownList)Page.Master.FindControl("dl");
                    myCart = ShoppingCart.NewRowCart((DataTable)Session["cart"], d.Product_ID, d.Name, d.Type, 1, d.Price);

                    Session["cart"] = myCart;
                    Session["count"] = myCart.Rows.Count;
                    Repeater rp = (Repeater)Page.Master.FindControl("rptr");
                    rp.DataSource = (DataTable)Session["cart"];
                    rp.DataBind();
                }
                else
                {
                    Label1.Text = "Only one item allowed on the cart";
                }

            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
        }



    }
}