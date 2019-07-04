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
	    ProjectManager prgMgr = new ProjectManager();
	    List<Project> projects = prgMgr.RetrieveDevelopmentProjects();

	    IcarusInformation soar = new IcarusInformation();
	    
	    ViewData["Projects"] = projects;
    	    ViewData["Header"] = "Development Projects";

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
