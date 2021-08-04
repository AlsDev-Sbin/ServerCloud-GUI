namespace ServerCloud.RemoteServerCloud.Model
{
	public class ModelInsertUser
	{
		public string UserName { get; set; }
		public string PrimaryName { get; set; }
		public string SecondName { get; set; }
		public string Pass { get; set; }
		public string? token { get; set; }
	}
}
