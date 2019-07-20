using System;

namespace KunDengWebsite.Models
{
    public class EmailInformation
    {
        public string SMTP { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Subject { get; set; }
        public int Port { get; set; }
    }
}
