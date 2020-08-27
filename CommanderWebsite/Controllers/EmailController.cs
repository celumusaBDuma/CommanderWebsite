using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Configuration;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading.Tasks;
using System.Web;
using System.Web.Services.Description;

namespace CommanderWebsite.Controllers
{
    public class EmailController
    {
        public static Task sendEmail(string destination, string subject, string body)
        {
            
            var smtp = new SmtpClient();
              var mail = new MailMessage();
              var smtpSection = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");
              string username = smtpSection.Network.UserName;

              mail.IsBodyHtml = true;
              mail.From = new MailAddress(username);
              mail.To.Add(destination);
              mail.Subject = subject;
              mail.Body = body;

              smtp.Timeout = 1000;

              var t = Task.Run(() => smtp.SendAsync(mail, null));

              return t;
 
        }
    }
}