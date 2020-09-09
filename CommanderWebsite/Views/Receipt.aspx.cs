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
    public partial class Receipt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Order_ID"]);
            CommanderEDM db = new CommanderEDM();
            var o = OrderController.getOrderID(id);
            var f = OrderController.getOrder(id);
            var custID = f.Customer_ID;
            var firstname = f.Customer.Firstname;
            var lastname = f.Customer.Lastname;
            string d = DateTime.Today.Date.ToShortDateString();
            datelbl.Text = String.Format("{0:d/M/yyyy}", d);
            Label1.Text = custID.ToString();
            Label3.Text = firstname.ToString() + " " + lastname.ToString();
            gv3.DataSource = o;
            gv3.DataBind();
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}