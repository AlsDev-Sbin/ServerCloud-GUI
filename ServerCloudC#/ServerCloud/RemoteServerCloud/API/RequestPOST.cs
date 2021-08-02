using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ServerCloud.RemoteServerCloud.API
{
	public abstract  class RequestPOST<T>
	{
		protected abstract EnumEndPoints.EndPoint Addr { get; set; }
		public async Task<T?> RequestServerCloud(object json)
		{
			var web = WebRequest.Create($"http://localhost/{EnumEndPoints.GetEndPoint(Addr)}");
			json = JsonConvert.SerializeObject(json);

			web.Method = "POST";
			web.ContentType = "application/json";
			web.ContentLength = json.ToString().Length;

			using (var req = await web.GetRequestStreamAsync())
				req.Write(ASCIIEncoding.UTF8.GetBytes(json.ToString()));

			var responseAsync = await web.GetResponseAsync();
			var stre = new StreamReader(responseAsync.GetResponseStream());
			var response = await stre.ReadToEndAsync();

			return JsonConvert.DeserializeObject<T>(response);
		}
	}
}
