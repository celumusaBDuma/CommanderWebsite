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
    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Label1.Visible = false;
            var s = Request.QueryString["s"];
            if (s == null || s == "")
            {
               Label1.Text = "No Results shown";
                Label1.Visible = true;
              
            }
            else{
                rep_bind(s);
                    if (listViewProducts.Items.Count != 0)
                    {
                        TextBox1.Text = s;
                        Label1.Visible = false;

                }

                    else
                    {
                        
                        Label1.Text = "No Results shown";
                    Label1.Visible = true;
                    }
                
            }
            
           
        }
        private void rep_bind(string s)
        {
            try { 
            if(s!= null) {
                CommanderEDM ds = new CommanderEDM();
                var prod = ProductsController.getSearchProd(TextBox1.Text);
                listViewProducts.DataSource = prod;
                listViewProducts.DataBind();
                }
            }
            catch(Exception ex)
            {
                Response.Write("alert('an error occured: " + ex + "');");
            }
        }
        private void rep_bind()
        {
            try { 
            CommanderEDM ds = new CommanderEDM();
            var prod = ProductsController.getSearchProd(TextBox1.Text);
            listViewProducts.DataSource = prod;
            listViewProducts.DataBind();
            }
            catch(Exception ex)
            {
                Response.Write("alert('an error occured: " + ex + "');");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

            CommanderEDM ds = new CommanderEDM();
            var prod = ProductsController.getSearchProd(TextBox1.Text);

            if (prod != null)
            {
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
            catch(Exception ex)
            {
                Response.Write("alert('an error occured: " + ex + "');");
            }
        }
    }
}