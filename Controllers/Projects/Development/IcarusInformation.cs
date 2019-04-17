using System;
using System.Collections.Generic;

namespace KunDengWebsite.Controllers.Projects.Development
{
	public class IcarusInformation
	{
		#region Fields
		List<string> _technologies;
		string _description;
		#endregion


		#region Properties
		public List<string> Technologies
		{
			get => _technologies;
			set => _technologies = value;
		}
		public string Description 
		{
			get => _description;
			set => _description = value;
		}
		#endregion


		#region Constructors
		public IcarusInformation()
		{
			Initialize();
		}
		#endregion


		#region Methods
		void Initialize()
		{
			InitializeDescription();
		}
		void InitializeDescription()
		{
			_description = "Icarus is a Music Streaming API Server that " +
						   "interacts with Mear.With Icarus users are able" +
						   " to store and retrieve their personal music " + 
						   "as well as stream and play it from their devices." +
						   "Icarus is licensed under the M.I.T. Open Source " +
						   "License and utilizes various technologies including:";
			InitializeTechnologies();
		}
		void InitializeTechnologies()
		{
			_technologies = new List<string>();
			_technologies.Add("C#");
			_technologies.Add(".NET Core");
			_technologies.Add(".NET Web RESTful API");
			_technologies.Add("MySql");
			_technologies.Add("Newtonsoft.Json");
			_technologies.Add("TagLib#");
			_technologies.Add("ID3");
		}
		#endregion
	}
}
