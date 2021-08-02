namespace ServerCloud.RemoteServerCloud.API
{
	public class EnumEndPoints
	{
		public enum EndPoint
		{
			#region INSERT

			InsertPath,
			InsertLink,
			InsertUser,

			#endregion

			#region SELECT

			LoginUser,
			SelectLink,
			SelectPath,

			#endregion

			#region UPDATE

			UpdatePath,
			UpdateLink,
			UpdateUser

			#endregion
		}

		public static string GetEndPoint(EndPoint endPoint) => $"ServerCloud/{endPoint}.php";
	}
}
