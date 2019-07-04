using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

using KunDengWebsite.Models;

namespace KunDengWebsite.Controllers
{
    public class MailSender
    {
        public static void SendToMyself(EmailMessage emailContent)
	{
	    var mail = new MailMessage();
	    var smtpServer = new SmtpClient("smtp.gmail.com");
	    mail.From = new MailAddress(emailContent.FromEmail);
	    mail.To.Add("kundeng94@gmail.com");
	    mail.Subject = "KunDengWebsite - Contact";
	    mail.Body = emailContent.Message;

	    smtpServer.Port = 587;
	    smtpServer.Credentials = new NetworkCredential("", "");
	    smtpServer.EnableSsl = true;

	    smtpServer.Send(mail);
	}
    }
}
