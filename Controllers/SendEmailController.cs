using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web;
using System.Web.Http;

using Microsoft.AspNetCore.Mvc;

using KunDengWebsite.Models;

namespace KunDengWebsite.Controllers
{
    public class SendEmailController : Controller
    {
        [HttpPost]
	public IActionResult SendEmail(EmailMessage emailContent)
	{
	    MailSender.SendToMyself(emailContent);
	    return View("Views/Landing/Contact.cshtml");
	}
    }
}
