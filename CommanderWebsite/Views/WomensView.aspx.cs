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
    public partial class WomensView : System.Web.UI.Page
    {
        DataTable myCart = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

            myCart = (DataTable)Session["cart"];

            if (!IsPostBack)
            {
                try
                {
                    int id = int.Parse(Request.QueryString["ProductID"]);

                    CommanderEDM db = new CommanderEDM();
                    var d = ProductsController.getByID(id);


                    string query = "select * from product where Product_ID=" + id;
                    String mycon = "Data Source=143.128.146.30;Initial Catalog = hon01;User ID=hon01;Password=s2q24";
                    SqlConnection con = new SqlConnection(mycon);
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    rptrImages2.DataSource = ds;
                    rptrImages2.DataBind();

                    if (d.Picture != null)
                    {
                        //    byte[] imageData = (byte[])d.Picture;
                        //   string img = Convert.ToBase64String(imageData, 0, imageData.Length);
                        im.ImageUrl = d.Picture;

                    }
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
                    myCart = ShoppingCart.NewRowCart((DataTable)Session["cart"], d.Product_ID);

                    Session["cart"] = myCart;
                    Session["CartCount"] = myCart.Rows.Count;
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