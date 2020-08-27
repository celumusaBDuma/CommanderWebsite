using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using CommanderWebsite.Models;
using SendGrid.Helpers.Mail;

namespace CommanderWebsite.Account
{
    public partial class ForgotPassword : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Forgot(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // Validate the user's email address
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                ApplicationUser user = manager.FindByName(Email.Text);
                var val = ""; 
                if (user.Email != null) {
                val = user.Email; }
                if (val == null )
                {
                    FailureText.Text = "The user either does not exist or is not confirmed.";
                    ErrorMessage.Visible = true;
                    return;
                }
                
                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                // Send email with the code and the redirect to reset password page
                string code = manager.GeneratePasswordResetToken(user.Id);
                string callbackUrl = IdentityHelper.GetResetPasswordRedirectUrl(code, Request);
                var message = new IdentityMessage()
                {
                   
                    Subject = "Reset Password",
                  Body = "Please reset your password by clicking <a href=\"" + callbackUrl + "\">here</a>.",
                    Destination = Email.Text
                };
                manager.EmailService.SendAsync(message);
                    loginForm.Visible = false;
                DisplayEmail.Visible = true;
            }
        }
    }
}