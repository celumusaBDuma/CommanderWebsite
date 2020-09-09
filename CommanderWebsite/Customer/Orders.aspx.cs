using CommanderWebsite.Controllers;
using CommanderWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace CommanderWebsite.Customer
{
    public partial class Orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            rep_bind();
        }

        protected void listViewProducts_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            try
            {
                if (listViewProducts.Items.Count < 1)
                {
                    if (e.Item.ItemType.Equals(ListItemType.Header))
                    {
                        HtmlGenericControl noRecordsDiv = (e.Item.FindControl("NoRecords") as HtmlGenericControl);
                        if (noRecordsDiv != null)
                        {
                            noRecordsDiv.Visible = true;
                        }
                    }
                }
                ListViewDataItem item = (ListViewDataItem)e.Item;
                if (e.Item.ItemType.Equals(ListItemType.Item) || e.Item.ItemType.Equals(ListItemType.AlternatingItem))
                {

                    Label lbl = (Label)e.Item.FindControl("Label1");
                    string a = lbl.Text;
                    Session["val"] = a;


                    Label lbl2 = (Label)e.Item.FindControl("Label1");
                    string b = (string)Session["val"];
                    var dataT = ProductsController.getByID2(int.Parse(b));
                    if (dataT.Picture != null)
                    {

                        byte[] imageData = (byte[])dataT.Picture;
                        string img = Convert.ToBase64String(imageData, 0, imageData.Length);
                        Image imagew = (Image)e.Item.FindControl("imgs");
                        imagew.ImageUrl = "data:image/png;base64," + img;

                    }
                    else
                    {
                        Image imagew = (Image)e.Item.FindControl("imgs");
                        imagew.ImageUrl = "Content/Images/noImage.png";
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("alert('an error occured: " + ex + "');");
            }
        }


        private void rep_bind()
        {
            try
            {

                int id = int.Parse(Request.QueryString["Product_ID"]);
                CommanderEDM db = new CommanderEDM();
                var cus = CustomerController.FindByEmail(Context.User.Identity.Name);
                var prod = OrderController.getByCatID4(id, cus.Customer_ID);


                listViewProducts.DataSource = prod;
                listViewProducts.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('an error occured: " + ex + "')</script>");
            }
        }
    }
}