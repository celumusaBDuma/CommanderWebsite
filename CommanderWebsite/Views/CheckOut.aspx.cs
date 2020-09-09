using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CommanderWebsite.Models;
using CommanderWebsite.Controllers;

namespace CommanderWebsite.Views
{
    public partial class CheckOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try { 
            int id = int.Parse(Request.QueryString["Product_ID"]);
            CommanderEDM db = new CommanderEDM();
            var dt = CartController.GetCartItems(Context.User.Identity.Name, id);
            rprtCart1.DataSource = dt;
            rprtCart1.DataBind();
            if (dt.Count != 0)
            {

                var dataT = ProductsController.getByID2(id);
                if (dataT.Picture != null)
                {
                    byte[] imageData = (byte[])dataT.Picture;
                    string img = Convert.ToBase64String(imageData, 0, imageData.Length);
                    imsdf1.ImageUrl = "data:image/png;base64," + img;

                }
                else
                {
                    imsdf1.ImageUrl = "~/Content/Images/noImage.png";
                }
            }
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
                Label2.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnProceed_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(Request.QueryString["Product_ID"]);
                if (!String.IsNullOrEmpty(TextBox2.Text)) { 
                    CommanderEDM db = new CommanderEDM();
                    var getCart = CartController.GetCartItems(Context.User.Identity.Name, id);
                    var cartI = CartController.GetCartItems1(Context.User.Identity.Name, id);
                    PaymentsController.InsertPayment(Context.User.Identity.Name,cartI.Price);
                    DeliveryController.InsertDelivery(TextBox2.Text, Context.User.Identity.Name);
                    var payID = PaymentsController.LastPay(Context.User.Identity.Name);
                    var delID = DeliveryController.getLastID(Context.User.Identity.Name);
                    OrderController.InsertOrder(Context.User.Identity.Name,id,payID,delID,cartI.Price);
                    CartController.removeItem(id, Context.User.Identity.Name);
                    int d = OrderController.getOrderID(Context.User.Identity.Name);
                    Response.Redirect("~/Views/Receipt.aspx?Order_ID="+d,false);
                }
                else
                {
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                sa.Text = ex.ToString();
            }
            
        }
    }
}