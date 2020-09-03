using CommanderWebsite.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using CommanderWebsite.Models;

namespace CommanderWebsite.Views
{
    public partial class Men : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rep_bind();
        }

        protected void listViewProducts_ItemDataBound(object sender, ListViewItemEventArgs e)
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
                if (dataT.Picture!= null)
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


        private void rep_bind()
        {
            CommanderEDM db = new CommanderEDM();
            var catQuery = CategoryController.getCatById("Men");
            var prod = ProductsController.getByCatID(catQuery);
            
            
            listViewProducts.DataSource = prod;
            listViewProducts.DataBind();
           
        }
    }
}