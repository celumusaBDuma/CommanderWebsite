using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace CommanderWebsite.Admin
{
    public partial class ProductsAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //   SqlDBConnection sqlcon = new SqlDBConnection();
                //   DataTable dt = sqlcon.QueryPackagesTable();
                //       rptrPackages.DataSource = dt;
             //   rptrPackages.DataBind();
            }
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
            ListViewDataItem item = (ListViewDataItem) e.Item;
            // if (e.Item.ItemType.Equals(ListItemType.Item) || e.Item.ItemType.Equals(ListItemType.AlternatingItem))
            //{

            //         Label lbl = (Label)e.Item.FindControl("Label1");
            //          string a = lbl.Text;
            //            Session["val"] = a;

            //   UniqueDrivingSchoolWebsite.SqlDBConnection sqlcon = new UniqueDrivingSchoolWebsite.SqlDBConnection();
            //              Label lbl2 = (Label)e.Item.FindControl("Label1");
            //                string b = (string)Session["val"];
            // System.Data.DataTable dataT = sqlcon.QueryPackagesTableID(int.Parse(b));
            //  if (dataT.Rows[0]["PackagePicture"] != DBNull.Value)
            // {
            //       byte[] imageData = (byte[])dataT.Rows[0]["PackagePicture"];
            //      string img = Convert.ToBase64String(imageData, 0, imageData.Length);
            //      Image imagew = (Image)e.Item.FindControl("imgs");
            //     imagew.ImageUrl = "data:image/png;base64," + img;

            // }
            //   else
            //  {
            //           Image imagew = (Image)e.Item.FindControl("imgs");
            //         imagew.ImageUrl = "Resources/noImage.png";
            //  }


        }

        
    }
}