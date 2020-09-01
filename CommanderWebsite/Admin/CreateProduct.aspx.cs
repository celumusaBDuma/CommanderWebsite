using System;
using System.Data.SqlClient;
using System.Configuration;

namespace CommanderWebsite.Admin
{
    public partial class CreateProduct : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string str = FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Content/Images/"+ DropDownList1.SelectedItem.Text +"/"+ str));
                string imgpath = "~/Content/Images/" + DropDownList1.SelectedItem.Text + "/" + str.ToString();
                string mainconn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                SqlConnection sqlcon = new SqlConnection(mainconn);
                SqlCommand sqlcomm = new SqlCommand("insert into [dbo].[Product] (Name,Category_ID, Description, Price, Picture) values (@Name, @Category_ID, @Description, @Price, @Picture)", sqlcon);
                sqlcomm.Parameters.AddWithValue("@Name", TxtPrdName.Text);
                sqlcomm.Parameters.AddWithValue("@Category_ID", int.Parse(DropDownList1.SelectedItem.Value));
                sqlcomm.Parameters.AddWithValue("@Description", TxtPrdDesc.Text);
                sqlcomm.Parameters.AddWithValue("@Price", TxtProdPrice.Text);
                sqlcomm.Parameters.AddWithValue("@Picture", imgpath);
                sqlcon.Open();
                sqlcomm.ExecuteNonQuery();
                sqlcon.Close();
                Label2.Text = "Saved Successfully... !";
                Label2.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                Label2.Text = "Oops... !";
                Label2.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
