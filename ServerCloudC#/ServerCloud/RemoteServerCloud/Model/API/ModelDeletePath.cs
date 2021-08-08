using System;
using System.Collections.Generic;
using System.Linq;
namespace ServerCloud.RemoteServerCloud.Model.API
{
	class ModelDeletePath
	{
		public int? Id { get; set; }
		public int[] Paths { get; set; }
		public string[] Links { get; set; }
		public bool paths_deleted { get; set; }
		public bool files_deleted { get; set; }
	}
}
