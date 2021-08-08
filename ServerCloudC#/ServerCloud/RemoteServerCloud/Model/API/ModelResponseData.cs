using System.Collections.Generic;

namespace ServerCloud.RemoteServerCloud.Model
{
	public class ModelResponseData
	{
		public int id { get; set; }
		public List<Link>? links { get; set; }
		public List<paths>? paths { get; set; }
		public List<user?> user { get; set; }
		public bool Exist { get; set; }
	}

	public class Link
	{
		public int? Id { get; set; }
		public int? IdUser { get; set; }
		public string? IdLink { get; set; }
		public string? FileName { get; set; }
		public int? bytes { get; set; }
		public string? str_bytes { get; set; }
		public int? IdPath { get; set; }
		public string? UniqFileInPath { get; set; }
	}

	public class paths
	{
		public int? Id { get; set; }
		public string? Path { get; set; }
		public int? Parent { get; set; }
		public bool paths_deleted { get; set; }
		public bool files_deleted { get; set; }
	}

	public class user
	{
		public int Id { get; set; }
		public string PrimaryName { get; set; }
		public string SecondName { get; set; }
		public string Token { get; set; }
	}
}
