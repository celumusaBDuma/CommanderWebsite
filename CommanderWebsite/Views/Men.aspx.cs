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
    public partial class Men : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rep_bind();
        }
        private void rep_bind()
        {

            string query = "select * from product where category_id=1";
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
    }
}