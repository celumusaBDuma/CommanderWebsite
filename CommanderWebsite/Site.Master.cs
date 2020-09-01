using System;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using System.Web.UI.HtmlControls;
using System.Net.Configuration;
using System.Configuration;
using CommanderWebsite.Models;
using CommanderWebsite.Controllers;

namespace CommanderWebsite
{
    public partial class SiteMaster : MasterPage
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

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["CartCount"] = 0;
            CommanderEDM db = new CommanderEDM();
            var userRow = AdminController.FindByEmailAdmin(Context.User.Identity.GetUserName());
            if (userRow != null)
            {

                if (userRow.Picture != null)
                {
                    byte[] imageData = (byte[])userRow.Picture;
                    string img = Convert.ToBase64String(imageData, 0, imageData.Length);
                    Image imagesomet = (Image)LoginViewHome.FindControl("Image4");
                    imagesomet.ImageUrl = "data:image/png;base64," + img;
                }

            }
            else
            {
                var userRow1 = CustomerController.FindByEmail(Context.User.Identity.GetUserName());
                if (userRow1 != null)
                {
                    if (userRow1.Picture != null)
                    {
                        byte[] imageData = (byte[])userRow1.Picture;
                        string img = Convert.ToBase64String(imageData, 0, imageData.Length);
                        Image imagesomet = (Image)LoginViewHome.FindControl("Image4");
                        imagesomet.ImageUrl = "data:image/png;base64," + img;
                    }
                }
            }

        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }

        protected void btnEmail_Click(object sender, EventArgs e)
        {
            try
            {
                var smtpSection = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");
                System.Net.Mail.MailMessage mm = new System.Net.Mail.MailMessage();
                mm.From = new System.Net.Mail.MailAddress(smtpSection.Network.UserName);
                mm.Subject = "NewsLetter Subcription";
                mm.To.Add(new System.Net.Mail.MailAddress(tbEmailHome.Text));
                mm.Body = "Hi I would like to subscribe to your newsletter, account is " + tbEmailHome.Text;
                EmailController.sendEmail(mm.To.ToString(), mm.Subject, mm.Body);

                }
            catch (Exception ex)
            {

                Label1.Text = ex.ToString();

            }
        }
    }

}