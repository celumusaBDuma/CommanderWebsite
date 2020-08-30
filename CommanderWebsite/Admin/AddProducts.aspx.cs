using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommanderWebsite.Controllers;
using System.Data.SqlClient;
using System.Data;

namespace CommanderWebsite.Admin
{
    public partial class AddProducts : System.Web.UI.Page
    {
        static string imagelink;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getProductId();
                var list = CategoryController.getCategoryList();
                foreach (int li in list)
                {
                    DropDownList1.Items.Add(li.ToString());
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (uploadimage() == true)
            {
                int cId = int.Parse(DropDownList1.Text);
                int aId = 1;
                String query = "insert into product(name,type,description,quantity,size,price,picture,admin_id,category_id) values('" + TextBox1.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox2.Text + "','" + imagelink + "','" + aId + "','" + cId + "')";
                String mycon = "Data Source=143.128.146.30;Initial Catalog = hon01;User ID=hon01;Password=s2q24";
                SqlConnection con = new SqlConnection(mycon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                Label3.Text = "Product Has Been Successfully Saved";
                getProductId();
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
        }




        private Boolean uploadimage()
        {
            Boolean imagesaved = false;
            if (FileUpload1.HasFile == true)
            {

                String contenttype = FileUpload1.PostedFile.ContentType;

                if (contenttype == "image/jpeg")
                {

                    FileUpload1.SaveAs(Server.MapPath("~/Content/Images/") + Label2.Text + ".jpg");
                    imagelink = "images/" + Label2.Text + ".jpg";
                    imagesaved = true;
                }
                else
                {
                    Label4.Text = "Kindly Upload JPEG Format Image Only";
                }

            }

            else
            {
                Label4.Text = "You have not selected any file - Browse and Select File First";
            }

            return imagesaved;

        }



        public void getProductId()
        {
            String mycon = "Data Source=143.128.146.30;Initial Catalog = hon01;User ID=hon01;Password=s2q24";
            SqlConnection scon = new SqlConnection(mycon);
            String myquery = "select Product_ID from Product";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = scon;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            scon.Close();
            if (ds.Tables[0].Rows.Count < 1)
            {
                Label2.Text = "1";

            }
            else
            {
                String mycon1 = "Data Source=143.128.146.30;Initial Catalog = hon01;User ID=hon01;Password=s2q24";
                SqlConnection scon1 = new SqlConnection(mycon1);
                String myquery1 = "select max(Product_ID) from Product";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandText = myquery1;
                cmd1.Connection = scon1;
                SqlDataAdapter da1 = new SqlDataAdapter();
                da1.SelectCommand = cmd1;
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                Label2.Text = ds1.Tables[0].Rows[0][0].ToString();
                int a;
                a = Convert.ToInt16(Label2.Text);
                a = a + 1;
                Label2.Text = a.ToString();
                scon1.Close();
            }
        }
    }
}