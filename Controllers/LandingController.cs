
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
