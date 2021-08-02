using System;
using System.Collections.Generic;

namespace ServerCloud.RemoteServerCloud.Model
{
	public class RootJsonResponse : IDisposable
	{
		public List<ModelResponseData?> data { get; set; }
		public InformationRequest? InformationRequest { get; set; }

		public void Dispose() =>
			GC.SuppressFinalize(this);
	}
	public class InformationRequest
	{
		public int ValueError { get; set; }
		public string? MessageError { get; set; }
	}
}
