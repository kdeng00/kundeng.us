using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web;
using System.Web.Http;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

using KunDengWebsite.Models;

namespace KunDengWebsite.Controllers
{
    public class SendEmailController : Controller
    {
        private IConfiguration _config;

        public SendEmailController(IConfiguration config)
        {
            _config = config;
        }


        [HttpPost]
        public IActionResult SendEmail(EmailMessage emailContent)
        {
            MailSender.SendToMyself(emailContent, _config);
	    
            return View("Views/Landing/Contact.cshtml");
	
        }
    }
}
