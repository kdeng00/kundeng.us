using System;
using System.Collections.Generic;
using System.Text;

using KunDengWebsite.Models;

namespace KunDengWebsite.Controllers.Projects.Development
{
	public class ProjectManager
	{
		public List<Project> RetrieveDevelopmentProjects()
		{
			try
			{
				var icarusProject = RetrieveIcarus();
				var projects = new List<Project>();
				projects.Add(icarusProject);
				projects.Add(RetrieveMear());

				return projects;
			}
			catch (Exception ex)
			{
				var msg = ex.Message;
			}

			return null;
		}

		private Project RetrieveIcarus()
		{
			var project = new Project();
			project.Title = "Icarus";
			project.Description = "Icarus is a Music Streaming API Server that " +
					   "interacts with Mear.With Icarus users are able" +
					   " to store and retrieve their personal music " + 
					   "as well as stream and play it from their devices." +
					   "Icarus is licensed under the M.I.T. Open Source " +
					   "License and utilizes various technologies including:";
			project.DevelopmentTools = new List<string>{
				"C#", ".NET Core",
				".NET Web RESTful API", "MySql",
				"Newtonsoft.Json", "TagLib#"
			};

			return project;
		}
		private Project RetrieveMear()
		{
			var project = new Project();
			project.Title = "Mear";
			project.Description = "Mear is a customizable music player app";
			project.DevelopmentTools = new List<string>{
				"C#", "Xamarin Forms", "Newtonsoft.Json",
				"SQLite", "RestSharp", "XamarinMediaManager"
			};

			return project;
		}
	}
}
