using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

using Microsoft.Extensions.Configuration;

using KunDengWebsite.Models;

namespace KunDengWebsite.Controllers
{
    public class MailSender
    {
        public static void SendToMyself(EmailMessage emailContent, 
                IConfiguration config)
        {
            var mail = new MailMessage();
            var emailInfo = ParseEmailInfo(config);
        
            var smtpServer = new SmtpClient(emailInfo.SMTP);
            mail.From = new MailAddress(emailContent.FromEmail);
            mail.To.Add(emailInfo.Email);
            mail.Subject = emailInfo.Subject;
            mail.Body = emailContent.Message;

        
            smtpServer.Port = emailInfo.Port;
            smtpServer.Credentials = new NetworkCredential(emailInfo.Email, 
                emailInfo.Password);
            smtpServer.EnableSsl = true;

            smtpServer.Send(mail);
        }

        private static EmailInformation ParseEmailInfo(IConfiguration config)
        {
            return new EmailInformation
            {
                SMTP = config["EmailInformation:SMTP"],
                Email = config["EmailInformation:Email"],
                Password = config["EmailInformation:Password"],
                Subject = config["EmailInformation:Subject"],
                Port = Convert.ToInt32(config["EmailInformation:Port"].ToString())
            };
        }
    }
}
