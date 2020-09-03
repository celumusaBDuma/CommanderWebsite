using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommanderWebsite.Controllers;
using System.Data.SqlClient;
using System.Data;
using CommanderWebsite.Models;

namespace CommanderWebsite.Admin
{
    public partial class AddProducts : System.Web.UI.Page
    {
        static byte[]  imagelink;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
             
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
                
                CommanderEDM db = new CommanderEDM();
                ProductsController.InsertProd(TextBox1.Text,TextBox3.Text,TextBox4.Text,int.Parse(TextBox5.Text), TextBox6.Text, decimal.Parse(TextBox2.Text), imagelink, aId, cId );
                
                Label3.Text = "Product Has Been Successfully Saved";
             
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

                    int length = FileUpload1.PostedFile.ContentLength;
                    byte[] pic = new byte[length];
                    FileUpload1.PostedFile.InputStream.Read(pic, 0, length);
                    imagelink = pic;
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



        
    }
}