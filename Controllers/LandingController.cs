using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

using KunDengWebsite.Controllers.Projects.Development;
using KunDengWebsite.Models;

namespace KunDengWebsite.Controllers
{
    public class LandingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		public IActionResult Development()
		{
			IcarusInformation soar = new IcarusInformation();

			ViewData["Header"] = "Development Projects";
			ViewData["Icarus"] = "Icarus";
			ViewData["IcarusDescription"] = soar.Description;
			ViewData["IcarusTechnologies"] = soar.Technologies;

			return View();
		}

		public IActionResult Music()
		{
			return View();
		}

        public IActionResult Contact()
        {
            return View();
        }
    }
}
