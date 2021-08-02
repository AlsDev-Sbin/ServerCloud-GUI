using ServerCloud.RemoteServerCloud.Model;
using System;

namespace ServerCloud.RemoteServerCloud.API
{
	public class RequestServer : RequestPOST<RootJsonResponse>, IDisposable
	{
		public RequestServer(EnumEndPoints.EndPoint Address)
		{
			Addr = Address;
		}
		protected override EnumEndPoints.EndPoint Addr { get;  set; }

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}
	}
}
