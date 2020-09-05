using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommanderWebsite.Views
{
    public partial class Cart : System.Web.UI.Page
    {
        DataTable myCart = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            myCart = (DataTable)Session["cart"];


        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<CommanderWebsite.Models.Cart> CartList_GetData()
        {
            return null;
        }
    }
}