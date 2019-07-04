using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

using Microsoft.AspNetCore.Mvc;

using KunDengWebsite.Models;

namespace KunDengWebsite
{
    public class SendEmailController : Controller
    {
        [HttpPost]
	public IActionResult SendEmail(EmailMessage emailContent)
	{
	    Console.WriteLine("Contents");
	    Console.WriteLine($"From: {emailContent.FromEmail}");
	    Console.WriteLine($"Message: \n{emailContent.Message}");
	    return View("Views/Landing/Contact.cshtml");
	}
    }
}
