using HtmlAgilityPack;
using Newtonsoft.Json;
using ServerCloud.RemoteServerCloud.Model;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerCloud
{
	public class APIAnonFiles : IDisposable
	{
		/// <summary>
		/// Criar um usuário na plataforma AnonFiles.com.
		/// </summary>
		/// <param name="User"></param>
		/// <param name="Pass"></param>
		/// <returns></returns>
		public async Task<bool> CreateUser(string User, string Pass)
		{
			try
			{
				var web = new WebBrowser();
				web.Navigate("https://anonfiles.com/register");
				web.ScriptErrorsSuppressed = false;

				while (web.ReadyState != WebBrowserReadyState.Complete & web.Document is null)
					await Task.Delay(80);

				var inputName = web.Document.All.GetElementsByName("username").OfType<HtmlElement>().First();
				var inputPass = web.Document.All.GetElementsByName("password").OfType<HtmlElement>().First();
				var inputPassConfirm = web.Document.All.GetElementsByName("password_confirm").OfType<HtmlElement>().First();

				inputName.SetAttribute("value", User);
				inputPass.SetAttribute("value", Pass);
				inputPassConfirm.SetAttribute("value", Pass);

				var bt = web.Document.GetElementsByTagName("input").OfType<HtmlElement>().Last();
				bt.InvokeMember("Click");

				while (web.ReadyState != WebBrowserReadyState.Complete)
					await Task.Delay(80);

				GC.SuppressFinalize(web);
				return true;
			} catch
			{
				return false;
			}
		}

		public async Task<string?> GetTokenUser(string User, string Pass)
		{
			string? token = null;
			try
			{
				using (var web = new WebBrowser())
				{
					web.ScriptErrorsSuppressed = false;
					web.Navigate("https://anonfiles.com/login");
					var inputUser = web.Document.All.GetElementsByName("username").OfType<HtmlElement>().First();
					var inputPass = web.Document.All.GetElementsByName("password").OfType<HtmlElement>().First();

					while (web.ReadyState != WebBrowserReadyState.Complete & web.Document is null)
						await Task.Delay(80);

					web.Navigate("https://anonfiles.com/docs/api");

					while (web.ReadyState != WebBrowserReadyState.Complete)
						await Task.Delay(80);

					var code = web.Document.GetElementsByTagName("code").OfType<HtmlElement>().First();
					token = code.GetAttribute("value");
					GC.SuppressFinalize(web);
				}
			} catch { }
			return token;
		}

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

		public async Task DownloadFile(string link, string FileName, Action callback = null)
		{
			await Task.Run(() =>
			{
				var web = new HtmlWeb();
				var doc = web.Load(link);
				var tag_download = doc.GetElementbyId("download-url");
				var download_link = tag_download.GetAttributeValue("href", "");

				var webDownload = new WebClient();
				webDownload.DownloadFile(download_link, FileName);

				if (callback is not null)
					callback();
			});
		}

		public void Dispose() =>
			GC.SuppressFinalize(this);
	}
}
