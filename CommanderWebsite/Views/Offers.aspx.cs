using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommanderWebsite.Views
{
    public partial class Offers : System.Web.UI.Page
    {
        DataTable myCart = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            myCart = (DataTable)Session["cart"];


        }
    }
}