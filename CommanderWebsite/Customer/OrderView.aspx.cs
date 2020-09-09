using CommanderWebsite.Controllers;
using CommanderWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommanderWebsite.Customer
{
    public partial class OrderView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                try
                {
                    int id = int.Parse(Request.QueryString["Product_ID"]);

                    CommanderEDM db = new CommanderEDM();
                    var cus = CustomerController.FindByEmail(Context.User.Identity.Name);
                    var d1 = OrderController.getByCatID4(id, cus.Customer_ID);
                    var d = OrderController.getOrder(id);
                    rptrImages2.DataSource = d1;
                    rptrImages2.DataBind();
                    if (d.Product.Picture != null)
                    {
                        byte[] imageData = (byte[])d.Product.Picture;
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
                }
            }

        }
    }
}