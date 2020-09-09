using CommanderWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommanderWebsite.Customer
{
    public partial class DashboardCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Label3.Text = Context.User.Identity.Name;
                CommanderEDM db = new CommanderEDM();
                var userRow = CustomerController.FindByEmail(Context.User.Identity.Name);
                if (userRow == null)
                {
                    Response.Redirect("~/");
                }
                if (userRow != null)
                {
                    if (userRow.Picture != null)
                    {
                        byte[] imageData = (byte[])userRow.Picture;
                        string img = Convert.ToBase64String(imageData, 0, imageData.Length);
                        Image1.ImageUrl = "data:image/png;base64," + img;
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex + "')</script>");
            }
        }
    }
}