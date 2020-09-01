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
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
        }
        private void rep_bind()
        {

            string query = "select * from product where Name like'%" + TextBox1.Text + "%'";
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
            listViewProducts.DataSource = ds;
            listViewProducts.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = "select * from product where Name like'%" + TextBox1.Text + "%'";
            String mycon = "Data Source=143.128.146.30;Initial Catalog = hon01;User ID=hon01;Password=s2q24";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();

                rep_bind();
                listViewProducts.Visible = true;

                TextBox1.Text = "";
                Label1.Text = "";
            }
            else
            {
                listViewProducts.Visible = false;
                Label1.Visible = true;
                Label1.Text = "The search Term " + TextBox1.Text + " &nbsp;Is Not Available in the Records"; ;

            }
        }
    }
}