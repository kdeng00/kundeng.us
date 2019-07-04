using System;
using System.ComponentModel.DataAnnotations;

namespace KunDengWebsite.Models
{
    public class EmailMessage
    {
        public string FromEmail { get; set; }
	public string Message { get; set; }
    }
}
