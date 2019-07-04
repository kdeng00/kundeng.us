using System;
using System.Collections.Generic;
using System.Text;

namespace KunDengWebsite.Models
{
    public class Project
    {
        public string Title { get; set; }
	public string Description { get; set; }
	public List<string> DevelopmentTools { get; set; }
    }
}
