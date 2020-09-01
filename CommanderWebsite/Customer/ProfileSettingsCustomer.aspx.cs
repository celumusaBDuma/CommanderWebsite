using CommanderWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommanderWebsite.Customer
{
    public partial class ProfileSettingsCustomer : System.Web.UI.Page
    {
        CommanderEDM DS = new CommanderEDM();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = User.Identity.Name;
           
            try
            {
                
                var userRow = CustomerController.FindByEmail(Label1.Text);
                if (!IsPostBack)
                {
                    
                    if (userRow.Picture != null)
                    {
                        byte[] imageData = userRow.Picture;
                        string img = Convert.ToBase64String(imageData, 0, imageData.Length);
                        image1.ImageUrl = "data:image/png;base64," + img;
                    }
                    if (userRow.Firstname != null) { 
                    tbFirstName.Text = userRow.Firstname;
                    }

                    if (userRow.Lastname != null)
                    {
                        tbLastName.Text = userRow.Lastname;
                    }

                    if (userRow.DOB != null)
                    {
                        Calender1.SelectedDate = (DateTime)userRow.DOB;
                        tbDOB.Text = Calender1.SelectedDate.ToShortDateString();
                    }

                    if (userRow.Gender != null)
                    {
                        dpGender.Text = userRow.Gender;
                    }

                    if (userRow.Cellphone != null)
                    {
                        tbCellphone.Text = userRow.Cellphone;
                    }

                    if (userRow.Address != null)
                    {
                        tbHouseNumber.Text = userRow.Address;
                    }
                    tbEmail.Text = userRow.Email;

                }
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
                Label2.Visible = true;
            }
        }

        protected void Calender_SelectionChanged(object sender, EventArgs e)
        {
            tbDOB.Text = Calender1.SelectedDate.ToShortDateString();
            Calender1.Visible = false;
        }

        protected void ImageButton2_Click(object sender, EventArgs e)
        {
            if (Calender1.Visible == false)
            {
                Calender1.Visible = true;
            }
            else
            {
                Calender1.Visible = false;
            }

        }

        protected void Update_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerController.UpdateCustomer(tbFirstName.Text, tbLastName.Text, tbDOB.Text, dpGender.Text, tbCellphone.Text, tbHouseNumber.Text, tbEmail.Text); 

                Label2.Text = "Update is Successful!!!";
                Label1.ForeColor = System.Drawing.Color.Green;
                Label2.Visible = true;
            }
            catch (Exception ex)
            {
                Label2.Text = ex.ToString();
                Label2.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            fileup.Visible = true;
            btnUpload.Visible = true;
            Button1.Visible = false;
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            var userRow = CustomerController.FindByEmail(Label1.Text);
            if (!fileup.HasFile)
            {
                Label3.Text = "Please Insert an Image";
            }
            else
            {
                int length = fileup.PostedFile.ContentLength;
                byte[] pic = new byte[length];
                fileup.PostedFile.InputStream.Read(pic, 0, length);
                CustomerController.updatePic(tbEmail.Text, pic);

                if (userRow.Picture != null)
                {
                    byte[] imageData = (byte[])userRow.Picture;
                    string img = Convert.ToBase64String(imageData, 0, imageData.Length);
                    image1.ImageUrl = "data:image/png;base64," + img;
                }
                Label3.Text = "Uploaded";
                fileup.Visible = false;
                btnUpload.Visible = false;
                Button1.Visible = true;
                Response.Redirect("/Customer/ProfileSettingsCustomer.aspx");

            }
        }

    }
}