using System;
using ServerCloud.RemoteServerCloud.Model;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ServerCloud
{
	public class APIAnonFiles : IDisposable
	{

		public async Task<ModelAPIAnonFiles?> UploadFile(ModelAPIAnonFiles modelApi, string PathFile)
		{
			string response = "";
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://api.anonfiles.com/upload");
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				using (var part = new MultipartFormDataContent())
				{
					var byteArray = new ByteArrayContent(System.IO.File.ReadAllBytes(PathFile));
					part.Add(byteArray, "file", modelApi.data.file.metadata.name);

					response = await (await client.PostAsync("", part)).Content.ReadAsStringAsync();
				}
			}

			return JsonConvert.DeserializeObject<ModelAPIAnonFiles>(response);
		}

		public void Dispose() =>
			GC.SuppressFinalize(this);
	}
}
