using CommanderWebsite.Controllers;
using CommanderWebsite.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommanderWebsite.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            var s = mySearchbtn.Value; ;
            Response.Redirect("~/Views/Search.aspx?s=" + s.ToString());
        }

        protected void Search_Click1(object sender, EventArgs e)
        {
            var s = mySearch.Value; ;
            Response.Redirect("~/Views/Search.aspx?s=" + s.ToString());
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Context.User.Identity.IsAuthenticated == false)
                {
                    Response.Redirect("~/Account/Login");
                }
                CommanderEDM db = new CommanderEDM();
                var userRow = AdminController.FindByEmailAdmin(Context.User.Identity.Name);
                 if(userRow == null) 
                 {
                     Response.Redirect("~/");
                 }
                if (userRow != null)
                {
                    if (userRow.Picture != null)
                    {
                        byte[] imageData = (byte[])userRow.Picture;
                        string img = Convert.ToBase64String(imageData, 0, imageData.Length);
                        Image imagesomet = (Image)cdLoginView.FindControl("Image4");
                        imagesomet.ImageUrl = "data:image/png;base64," + img;
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex + "')</script>");
            }
        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }

    }
}